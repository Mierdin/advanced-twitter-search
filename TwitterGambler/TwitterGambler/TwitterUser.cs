using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitterGambler
{
    class TwitterUser
    {
        private string username;
        private List<String[]> tweets;

        public TwitterUser(string username, List<String[]> tweets)
        {
            this.username = username;
            this.tweets = tweets;
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public List<String[]> Tweets
        {
            get { return this.tweets; }
            set { this.tweets = value; }
        }
    }
}
