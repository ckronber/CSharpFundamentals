using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class Show:StreamingContent
    {
        public Show() { }
        //new up a list as a property, in case one does not exist
        public List<Episode> Episode { get; set; } = new List<Episode>();
        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageRunTime { get; set; }

    }

    public class Episode
    {
        public string Title { get; set; }
        public double Runtime { get; set; }
        public int EpisodeNumber { get; set; }
        public int SeasonNumber { get; set; }
    }
}
