using System;
namespace FinalProject
{
    public class Playlist
    {
        public void BuildPlaylist(Favorite favorite)
        {
            int range = favorite.FavoriteSongCount();

            for(int i = 0; i< 10; i++)
            {
                Random rndm = new Random();
                int index = rndm.Next(range);
                favorite.GetAllAlbums().ElementAt(index);
            }
        }

    }
}