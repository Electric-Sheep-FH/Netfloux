using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netfloux
{
    public class Movie : Content, ISelectable
    {
        public Movie(string mainName, TimeSpan duration, string director, int numberViews) : base(mainName, duration, director, numberViews)
        {
        }

        public void Selected(User user)
        {
            user.WatchContent(this);
        }

        public override string ToString()
        {
            return $"Nom : \"{MainName}\"\nDirecteur : {Director}\nDurée de l'épisode : {Duration}\nNombres de vues : {NumberViews}\n";
        }
    }
}
