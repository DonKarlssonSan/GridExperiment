using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridExperiment.Data
{
    public class PocoData
    {
        public static List<PodCast> GetAllPodCasts()
        {
            return new List<PodCast>()
                {
                    new PodCast()
                        {
                            Name = "Hanselminutes",
                            Url = new Uri("http://hanselminutes.com"),
                            EpisodeCount = 375,
                            Language = "English"
                        },
                    new PodCast()
                        {
                            Name = "Herding Code",
                            Url = new Uri("http://herdingcode.com/"),
                            EpisodeCount = 168,
                            Language = "English"
                        },
                    new PodCast()
                        {
                            Name = "FLOSS Weekly",
                            Url = new Uri("http://twit.tv/show/floss-weekly"),
                            EpisodeCount = 255,
                            Language = "English"
                        },
                    new PodCast()
                        {
                            Name = "Kodsnack",
                            Url = new Uri("http://kodsnack.se"),
                            EpisodeCount = 22,
                            Language = "Swedish"
                        },
                    new PodCast()
                        {
                            Name = "This Developer's Life",
                            Url = new Uri("http://thisdeveloperslife.com/"),
                            EpisodeCount = 25,
                            Language = "English"
                        },
                    new PodCast()
                        {
                            Name = ".NET Rocks!",
                            Url = new Uri("http://www.dotnetrocks.com/"),
                            EpisodeCount = 880,
                            Language = "English"
                        }
                };
        } 
    }
}
