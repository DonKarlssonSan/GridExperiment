using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridExperiment.Data
{
    public class PodCast
    {
        public string Name { get; set; }
        public Uri Url { get; set; }
        public int EpisodeCount { get; set; }
        public string Language { get; set; }
    }
}
