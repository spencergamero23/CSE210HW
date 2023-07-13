using System;
namespace FinalProject
{
    public class Loader
    {
        public void LoadMusic(MusicList favorite, MusicList dislike)
        {
            LoadMusicSongList("Favsongs", favorite);
            LoadMusicSongList("BadSongs", dislike );
            LoadMusicAlbumList("FavAlbums",favorite);
            LoadMusicAlbumList("BadAlbums",dislike);
        }
        
        private void LoadMusicSongList(string FileName, MusicList music)
        {
            string[] lines = System.IO.File.ReadAllLines(FileName);

            foreach(string line in lines)
            {
                string[] parts = line.Split(",");
                string name = parts[0];
                string artist = parts[1];

                SongEntry songEntry = new SongEntry();
                songEntry.Hold(name,artist);

                music.AddSong(songEntry);
            }
        }
        private void LoadMusicAlbumList(string FileName, MusicList music)
        {
            string[] lines = System.IO.File.ReadAllLines(FileName);

            foreach(string line in lines)
            {
                string[] parts = line.Split(",");
                string name = parts[0];
                string artist = parts[1];

                AlbumEntry albumEntry = new AlbumEntry();
                albumEntry.Hold(name,artist);

                music.AddAlbum(albumEntry);
            }
        }
    }
}