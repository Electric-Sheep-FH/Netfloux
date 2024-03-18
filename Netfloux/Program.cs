namespace Netfloux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User fabien = new User("fabien@meh.com", "Fab");
            User unknownViewer = new User("incognito@meh.com", "Pirate"); 

            TVshow bandOfBrothers = new TVshow("Band Of Brothers");
            TVshow rickAndMorty = new TVshow("Rick et Morty");

            Movie oldDune = new Movie("Dune", TimeSpan.FromMinutes(137), "David Lynch", 0);
            Movie DuneFirstPart = new Movie("Dune : Première partie", TimeSpan.FromMinutes(155), "Denis Vilmeneuve", 0);
            Movie DuneSecondPart = new Movie("Dune : Deuxième partie", TimeSpan.FromMinutes(166), "Denis Vilmeneuve", 0);

            Episode rick1 = new Episode("Rick et Morty", "Pilot", TimeSpan.FromMinutes(23), "Justin Roiland, Dan Harmon", 0, 1, rickAndMorty);
            Episode rick2 = new Episode("Rick et Morty", "Lawnmower Dog", TimeSpan.FromMinutes(22), "John Rice", 0, 2, rickAndMorty);
            Episode rick3 = new Episode("Rick et Morty", "Anatomy Park", TimeSpan.FromMinutes(25), "John Rice", 0, 3, rickAndMorty);
            Episode rick4 = new Episode("Rick et Morty", "M. Night Shaym-Aliens!", TimeSpan.FromMinutes(21), "Jeff Myers", 0, 4, rickAndMorty);
            Episode rick5 = new Episode("Rick et Morty", "Meeseeks and Destroy", TimeSpan.FromMinutes(23), "Bryan Newton", 0, 5, rickAndMorty);
            Episode rick6 = new Episode("Rick et Morty", "Rick Potion #9", TimeSpan.FromMinutes(24), "Stephen Sandoval", 0, 6, rickAndMorty);
            Episode rick7 = new Episode("Rick et Morty", "Raising Gazorpazorp", TimeSpan.FromMinutes(22), "Jeff Myers", 0, 7, rickAndMorty);
            Episode rick8 = new Episode("Rick et Morty", "Rixty Minutes", TimeSpan.FromMinutes(21), "Bryan Newton", 0, 8, rickAndMorty);
            Episode rick9 = new Episode("Rick et Morty", "Something Ricked This Way Comes", TimeSpan.FromMinutes(23), "John Rice", 0, 9, rickAndMorty);
            Episode rick10 = new Episode("Rick et Morty", "Close Rick-Counters of the Rick Kind", TimeSpan.FromMinutes(22), "Jeff Myers", 0, 10, rickAndMorty);

            Episode BoBepisode1 = new Episode("Band Of Brothers","Currahee", TimeSpan.FromMinutes(60), "David Leland", 0, 1,bandOfBrothers);
            Episode BoBepisode2 = new Episode("Band Of Brothers", "Day of Days", TimeSpan.FromMinutes(55), "David Frankel", 0, 2, bandOfBrothers);
            Episode BoBepisode3 = new Episode("Band Of Brothers", "Carentan", TimeSpan.FromMinutes(58), "David Leland", 0, 3, bandOfBrothers);
            Episode BoBepisode4 = new Episode("Band Of Brothers", "Replacements", TimeSpan.FromMinutes(50), "David Nutter", 0, 4, bandOfBrothers);
            Episode BoBepisode5 = new Episode("Band Of Brothers", "Crossroads", TimeSpan.FromMinutes(57), "Tom Hanks", 0, 5, bandOfBrothers);
            Episode BoBepisode6 = new Episode("Band Of Brothers", "Bastogne", TimeSpan.FromMinutes(62), "David Leland", 0, 6, bandOfBrothers);
            Episode BoBepisode7 = new Episode("Band Of Brothers", "The Breaking Point", TimeSpan.FromMinutes(49), "David Frankel", 0, 7, bandOfBrothers);
            Episode BoBepisode8 = new Episode("Band Of Brothers", "The Last Patrol", TimeSpan.FromMinutes(53), "David Nutter", 0, 8, bandOfBrothers);
            Episode BoBepisode9 = new Episode("Band Of Brothers", "Why We Fight", TimeSpan.FromMinutes(48), "Phil Alden Robinson", 0, 9, bandOfBrothers);
            Episode BoBepisode10 = new Episode("Band Of Brothers", "Points", TimeSpan.FromMinutes(65), "David Leland", 0, 10, bandOfBrothers);

            DuneFirstPart.Selected(fabien);
            bandOfBrothers.Selected(fabien);
            bandOfBrothers.Selected(fabien);
            bandOfBrothers.Selected(fabien);
            bandOfBrothers.Selected(fabien);
            rickAndMorty.Selected(fabien);
            rickAndMorty.Selected(fabien);

            DuneFirstPart.Selected(unknownViewer);
            rickAndMorty.Selected(unknownViewer);
            rickAndMorty.Selected(unknownViewer);
            rickAndMorty.Selected(unknownViewer);
            rickAndMorty.Selected(unknownViewer);
            rickAndMorty.Selected(unknownViewer);

            Console.WriteLine(rick1);
            Console.WriteLine(DuneFirstPart);

            fabien.DisplayWatchedContent();
        }
    }
}
