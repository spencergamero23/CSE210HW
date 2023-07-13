using System;
namespace FinalProject
{
    public class Saver
    {
        public void SaveAlbums(MusicList favorite, MusicList dislike)
        {
            string FileName = "FavAlbums";
          using(StreamWriter outputFile = new StreamWriter(FileName))
          {
            foreach (AlbumEntry album in favorite.GetAllAlbums() )
            {
                string data = album.ConvertToFile();
                outputFile.WriteLine(data);
            }
          }
            FileName = "BadAlbums";
          using (StreamWriter outputFile = new StreamWriter(FileName))
          {
            foreach(AlbumEntry album in dislike.GetAllAlbums())
            {
                string data = album.ConvertToFile();
                outputFile.WriteLine(data);
            }
          }
        }

        
        public void SaveSongs(MusicList favorite, MusicList dislike)
        {
            string FileName = "BadSongs";
          using (StreamWriter outputFile = new StreamWriter(FileName))
            {   
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