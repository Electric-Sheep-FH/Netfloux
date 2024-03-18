using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netfloux
{
    public class User
    {
        public string Mail { get; set; }
        public string Nickname { get; set; }
        public TimeSpan Watchtime { get; set; }
        public List<Content> WatchedContent { get; set; }
        public Dictionary<TVshow,int> WatchedDictionnary { get; set; }

        public User(string mail, string nickname)
        {
            Mail = mail;
            Nickname = nickname;
            Watchtime = new TimeSpan(0, 0, 0);
            WatchedContent = new List<Content>();
            WatchedDictionnary = new Dictionary<TVshow, int>();
        }
        public void WatchContent(Content content)
        {
            WatchedContent.Add(content);
            Watchtime += content.Duration;
            content.NumberViews++;

            if (content is Movie)
            {
                Console.WriteLine($"#############################\n{Nickname} à regardé le film \"{content.MainName}\".\n#############################\n");
            } else
            {
                Episode episode = (Episode)content;
                Console.WriteLine($"#############################\n{Nickname} à regardé l'épisode n°{episode.EpisodeNumber} : \"{episode.EpisodeName}\" de la série {content.MainName}.\n#############################\n");
            }
        }
        public void DisplayWatchTime()
        {
            Console.WriteLine($"#############################\n{Nickname} à passer {Watchtime.TotalMinutes} minutes devant Netfloux !\n#############################\n");
        }
        public void DisplayWatchedContent()
        {
            Console.WriteLine($"#############################\n{Nickname} vous avez visionnez le contenu suivant :\n");
            foreach (Content content in WatchedContent)
            {
                Console.WriteLine(content);
            }
            Console.WriteLine($"Soit une durée de visionnage totale de {Watchtime.TotalMinutes} minutes.\n#############################\n");
        }
        public void Select(ISelectable selectable)
        {
            selectable.Selected(this);
        }
    }
}
