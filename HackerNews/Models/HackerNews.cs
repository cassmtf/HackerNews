using System;
using System.Collections.Generic;


namespace HackerNews.Models
{
    public class HNStoryModel
    {
        public string by { get; set; }
        public int descendants { get; set; }
        public int id { get; set; }
        public List<int> kids { get; set; }
        public int score { get; set; }
        public long time { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class BestStoriesModel
    {
        public string title { get; set; }

        public string uri { get; set; }

        public string postedBy { get; set; }

        public DateTime time { get; set; }

        public int score { get; set; }

        public int commentCount { get; set; }

    }
}
