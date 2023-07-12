using System;
namespace FinalProject
{
    public class Loader
    {
        public void LoadFavSongs(Favorite favorite)
        {
            string FileName = "FavSongs";
            string[] lines = System.IO.File.ReadAllLines(FileName);

            foreach(string line in lines)
            {
                string[] parts = line.Split(",");
                string name = parts[0];
                string artist = parts[1];

                SongEntry songEntry = new SongEntry();
                songEntry.Hold(name,artist);

                favorite.AddSong(songEntry);
            }
        }
    }
}