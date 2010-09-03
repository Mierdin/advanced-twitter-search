using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwitterGambler
{
    class QueryResult
    {
        private string username;
        private string datetime;
        private string tweet;

        public QueryResult(string username, string datetime, string tweet)
        {
            this.username = username;
            this.datetime = datetime;
            this.tweet = tweet;
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Datetime
        {
            get { return this.datetime; }
            set { this.datetime = value; }
        }

        public string Tweet
        {
            get { return this.tweet; }
            set { this.tweet = value; }
        }
    }
}
