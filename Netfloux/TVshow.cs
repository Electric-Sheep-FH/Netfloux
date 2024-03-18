using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netfloux
{
    public class TVshow :ISelectable
    {
        public string ShowName { get; set; }
        public List<Episode> Episodes { get; set; }

        public TVshow(string showName)
        {
            Episodes = new List<Episode>();
            ShowName = showName;
        }

        public void DisplayEpisode()
        {
            Console.WriteLine("#############################\n");
            foreach (Episode episode in Episodes)
            {
                Console.WriteLine(episode + "\n");
            }
            Console.WriteLine("#############################\n");

        }

        public void Selected(User user)
        {
            if (user.WatchedDictionnary.ContainsKey(this))
            {
                user.WatchContent(Episodes[user.WatchedDictionnary[this]]);
                user.WatchedDictionnary[this]++;
            } else
            {
                user.WatchContent(Episodes[0]);
                user.WatchedDictionnary.Add(this, Episodes[0].EpisodeNumber);
            }

        }
    }
}
