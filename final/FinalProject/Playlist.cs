using System;
namespace FinalProject
{
    public class Playlist
    {
        public void BuildPlaylist(MusicList favorite)
        {
            // int range = favorite.FavoriteSongCount();
            var songs = favorite.GetAllSongs();
            if(songs.Count() == 0)
            {
                Console.WriteLine("THERE ARE NO SONGS AVAILABLE");
                Console.WriteLine("LOAD FILE");
                return;
            }

            for(int i = 0; i< 10; i++)
            {
                Random rndm = new Random();
                int index = rndm.Next(songs.Count());
                var song = songs[index];
                Console.WriteLine(song.ConvertToString());
            }
        }

    }
}