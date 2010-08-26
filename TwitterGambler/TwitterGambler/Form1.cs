using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TweetSharp.Twitter.Fluent;
using TweetSharp.Twitter.Model;
using System.Xml;
using System.Net;
using System.IO;

namespace TwitterGambler
{
    public partial class Form1 : Form
    {
        static List<TwitterUser> users = new List<TwitterUser>();
        List<String> keywords = new List<String>();
        static BackgroundWorker bw;

        public Form1()
        {
            InitializeComponent();
            loadKeywords();
            loadUsers();

        }

        private void btnAddTwitterUser_Click(object sender, EventArgs e)
        {
            //TODO: Make sure the user doesn't already exist before adding
            TwitterUser user = new TwitterUser(txtAddTwitterUser.Text, new List<String[]>());
            users.Add(user);

            if (txtAddTwitterUser.Text != "")
            {
                lbTwitterUsers.Items.Add(txtAddTwitterUser.Text);
                saveUsers();
                loadUsers();
            }
            else
            {
                MessageBox.Show("You must enter a twitter username.");
            }
        }

        private void btnAddKeyword_Click(object sender, EventArgs e)
        {
            if (txtAddTwitterUser.Text != "")
            {
                lbKeywords.Items.Add(txtAddKeyword.Text);
                saveKeywords();
                loadKeywords();
            }
            else
            {
                MessageBox.Show("You must enter a keyword.");
            }
            getTweetsAsync("Mierdin");
        }

        private void loadKeywords()
        {
            lbKeywords.Items.Clear();
            //TODO: File may not exist here.
            TextReader tr = new StreamReader("keywords.txt");
            try
            {
                String line;
                while ((line = tr.ReadLine()) != null)
                {
                    lbKeywords.Items.Add(line);
                }
                tr.Close();
            }
            catch { 
            
            }
            finally
            {
                tr.Close();
            }
        }

        private void saveKeywords()
        {
            if (File.Exists("keywords.txt")) { File.Delete("keywords.txt"); }

            TextWriter tw = new StreamWriter("keywords.txt");
            foreach (String user in lbKeywords.Items)
            {
                tw.WriteLine(user);
            }
            tw.Close();
        }

        private void loadUsers()
        {
            users.Clear();

            lbTwitterUsers.Items.Clear();
            //TODO: File may not exist here.
            TextReader tr = new StreamReader("users.txt");
            try
            {
                String line;
                while ((line = tr.ReadLine()) != null)
                {
                    lbTwitterUsers.Items.Add(line);
                    users.Add(new TwitterUser(line, new List<string[]>()));
                }
                tr.Close();
            }
            catch
            {

            }
            finally
            {
                tr.Close();
            }
        }

        private void saveUsers()
        {
            if (File.Exists("users.txt")) { File.Delete("users.txt"); }
            TextWriter tw = new StreamWriter("users.txt");
            foreach (String user in lbTwitterUsers.Items)
            {
                tw.WriteLine(user);
            }
            tw.Close();
        }

        public void getTweetsAsync(string username)
        {
                bw = new BackgroundWorker();
                bw.DoWork += bw_DoWork;
                bw.RunWorkerCompleted += bw_RunWorkerCompleted;
                bw.RunWorkerAsync(username);
        }

        private void btnDeleteTwitterUser_Click(object sender, EventArgs e)
        {
            if (lbTwitterUsers.SelectedItem.ToString() != "")
            {
                foreach (TwitterUser user in users)
                { 
                    if (user.Username == lbTwitterUsers.SelectedItem.ToString())
                    {
                        users.Remove(user);
                    }
                }
                lbTwitterUsers.Items.Remove(lbTwitterUsers.SelectedItem.ToString());
                saveUsers();
            }
        }

        private void btnDeleteKeyword_Click(object sender, EventArgs e)
        {
            if (lbKeywords.SelectedItem.ToString() != "")
            {
                lbKeywords.Items.Remove(lbKeywords.SelectedItem.ToString());
                saveKeywords();
            }
        }

        static void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            List<String[]> ret = new List<String[]>();

            try
            {
                WebRequest req = WebRequest.Create(new Uri("http://twitter.com/statuses/user_timeline/" + e.Argument.ToString() + ".xml"));

                req.Method = "GET";
                //     req.Credentials = new NetworkCredential(username.Trim(), password);
                XmlDocument doc = new XmlDocument();
                doc.Load(req.GetResponse().GetResponseStream());

                List<String> tweets = new List<String>();
                XmlNodeList updates = doc.GetElementsByTagName("text");
                foreach (XmlElement update in updates)
                {
                    tweets.Add(update.InnerText);
                }

                List<String> timestamps = new List<String>();
                XmlNodeList xtimestamps = doc.GetElementsByTagName("created_at");
                foreach (XmlElement xtimestamp in xtimestamps)
                {
                    String[] xtimestampinfo = xtimestamp.InnerText.Split('+');
                    timestamps.Add(xtimestampinfo[0].Trim());
                }

                //This adds an entry at the top of the returned list so we know the twitter user when we get to bw_RunWorkerCompleted
                String[] listName = { e.Argument.ToString() };
                ret.Add(listName);


                int i = 0;
                foreach (String item in tweets)
                {
                    String[] tweetInfo = new String[2];
                    tweetInfo[0] = timestamps.ElementAt(i).ToString();
                    tweetInfo[1] = item;
                    ret.Add(tweetInfo);
                    i++;
                }
            }
            catch (WebException webex)
            {
                //TODO: Rate limit exceeded. Only 150 requests per hour.
            }
            catch (Exception ex)
            {

            }
            e.Result = ret;
        }

        static void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<String[]> returnedTweetStack = (List<String[]>)e.Result;
            
            //Extract username and delete item in list
            String[] stackInfo = returnedTweetStack.ElementAt(0);
            String username = stackInfo[0];
            returnedTweetStack.RemoveAt(0);

            MessageBox.Show(returnedTweetStack.Count.ToString());
            foreach (TwitterUser user in users)
            {
                if (user.Username == username)
                {
                    user.Tweets.Clear();
                    foreach(String[] newTweet in returnedTweetStack)
                    {
                        user.Tweets.Add(newTweet);
                    }
                }
            }
            MessageBox.Show("DONE!");
        }

        private void btnViewUsersTweets_Click(object sender, EventArgs e)
        {
            foreach (TwitterUser user in users)
            {
                if (user.Username == textBox1.Text)
                {
                    dataGridView1.DataSource = user.Tweets;
                    MessageBox.Show(user.Tweets.Count.ToString());
                }
            }
        }

        private void btnGetTweets_Click(object sender, EventArgs e)
        {
            getTweetsAsync(textBox1.Text);
        }
    }
}
