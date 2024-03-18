using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netfloux
{
    public abstract class Content
    {
        public string MainName { get; set; }
        public TimeSpan Duration { get; set; }
        public string Director { get; set; }
        public int NumberViews { get; set; }

        protected Content(string mainName, TimeSpan duration, string director, int numberViews)
        {
            MainName = mainName;
            Duration = duration;
            Director = director;
            NumberViews = numberViews;
        }
    }
}
