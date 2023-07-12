using System;
namespace FinalProject
{
    public class Saver
    {
        public void SaveAlbums(Favorite favorite, Dislike dislike)
        {
            string FileName = "Albums";
          using (StreamWriter outputFile = new StreamWriter(FileName))
          {
            foreach (AlbumEntry album in favorite.GetAllAlbums() )
            {
                string data = album.ConvertToFile();
                outputFile.WriteLine(data);
            }
            foreach(AlbumEntry album in dislike.GetAllAlbums())
            {
                string data = album.ConvertToFile();
                outputFile.WriteLine(data);
            }
          }
        }

        
        public void SaveSongs(Favorite favorite, Dislike dislike)
        {
            string FileName = "Songs";
          using (StreamWriter outputFile = new StreamWriter(FileName))
            {   
                foreach (SongEntry song in favorite.GetAllSongs() )
                {
                    string data = song.ConvertToFile();
                    outputFile.WriteLine(data);
                }
                foreach(SongEntry song in dislike.GetAllSongs())
                {
                    string data = song.ConvertToFile();
                    outputFile.WriteLine(data);
                }
            }
            FileName = "FavSongs";
          using (StreamWriter outputFile = new StreamWriter(FileName))
            {   
                foreach (SongEntry song in favorite.GetAllSongs() )
                {
                    string data = song.ConvertToFile();
                    outputFile.WriteLine(data);
                }
            }
        }
      
    }
}