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
        List<QueryResult> results = new List<QueryResult>();
        static BackgroundWorker bw;
        int refreshRate;
        int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadKeywords();
            loadUsers();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            progressBar1.Visible = false;

            refreshRate = 600;
            i = refreshRate;

            progressBar1.Visible = true;
            foreach (String user in lbTwitterUsers.Items)
            {
                getTweetsAsync(user);
            }
            tmrRefreshTwitter.Enabled = true;
       }

        private void tmrRefreshTwitter_Tick(object sender, EventArgs e)
        {
            if (i <= 0)
            {
                progressBar1.Visible = true;
                foreach (String user in lbTwitterUsers.Items)
                {
                    getTweetsAsync(user);
                }
                i = refreshRate;
                lblCountdown.Text = i.ToString();
            }
            else
            {
                i += -1;
                lblCountdown.Text = i.ToString();
            }
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
            if (txtAddKeyword.Text != "")
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

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<String[]> returnedTweetStack = (List<String[]>)e.Result;
            
            //Extract username and delete item in list
            String[] stackInfo = returnedTweetStack.ElementAt(0);
            String username = stackInfo[0];
            returnedTweetStack.RemoveAt(0);
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
            progressBar1.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            results.Clear();
            foreach (String keyword in lbKeywords.Items)
            {
                foreach (TwitterUser user in users)
                {
                    foreach (String[] tweet in user.Tweets)
                    {
                        // MessageBox.Show("Seeing if " + tweet[1] + " contains " + txtKeyword.Text);
                        if (tweet[1].IndexOf(keyword) != -1)
                        {
                            results.Add(new QueryResult(user.Username, tweet[0], tweet[1]));
                        }
                    }
                }
            }
            dataGridView1.DataSource = results;
            progressBar1.Visible = false;
        }

        private void tsmiEx_Click(object sender, EventArgs e)
        {
            refreshRate = 10;
            i = 10;
            tsmiEx.Checked = true;
            tsmi5M.Checked = false;
            tsmi10M.Checked = false;
            tsmi30M.Checked = false;
            tsmi1H.Checked = false;
        }

        private void tsmi5M_Click(object sender, EventArgs e)
        {
            refreshRate = 300;
            i = 300;
            tsmiEx.Checked = false;
            tsmi5M.Checked = true;
            tsmi10M.Checked = false;
            tsmi30M.Checked = false;
            tsmi1H.Checked = false;
        }

        private void tsmi10M_Click(object sender, EventArgs e)
        {
            refreshRate = 600;
            i = 600;
            tsmiEx.Checked = false;
            tsmi5M.Checked = false;
            tsmi10M.Checked = true;
            tsmi30M.Checked = false;
            tsmi1H.Checked = false;
        }

        private void tsmi30M_Click(object sender, EventArgs e)
        {
            refreshRate = 1800;
            i = 1800;
            tsmiEx.Checked = false;
            tsmi5M.Checked = false;
            tsmi10M.Checked = false;
            tsmi30M.Checked = true;
            tsmi1H.Checked = false;
        }

        private void tsmi1H_Click(object sender, EventArgs e)
        {
            refreshRate = 3600;
            i = 3600;
            tsmiEx.Checked = false;
            tsmi5M.Checked = false;
            tsmi10M.Checked = false;
            tsmi30M.Checked = false;
            tsmi1H.Checked = true;
        }
    }
}
