using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netfloux
{
    public class Episode : Content
    {
        public string EpisodeName { get; set; }
        public int EpisodeNumber { get; set; }
        public TVshow AssociatedTVShow { get; set; }

        public Episode(string mainName, string episodeName, TimeSpan duration, string director, int numberViews, int episodeNumber, TVshow associatedTVShow) : base(mainName, duration, director, numberViews)
        {
            EpisodeName = episodeName;
            EpisodeNumber = episodeNumber;
            AssociatedTVShow = associatedTVShow;

            AssociatedTVShow.Episodes.Add(this);
        }

        public override string ToString()
        {
            return $"Episode n°{EpisodeNumber} de la série \"{MainName}\"\nNom : \"{EpisodeName}\"\nDirecteur : {Director}\nDurée de l'épisode : {Duration}\nNombres de vues : {NumberViews}\n";
        }

    }
}
