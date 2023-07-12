using System;
namespace FinalProject
{
    public class Dislike : List
    {
        private List<SongEntry> _badSongs;
        private List<AlbumEntry> _badAlbums;

        public Dislike()
        {
            _badSongs = new List<SongEntry>();
            _badAlbums = new List<AlbumEntry>();
        }
        public override void AddSong(SongEntry song)
        {
            if(! _badSongs.Contains(song))
            {
                _badSongs.Add(song);
            }
        }
        public override void AddAlbum(AlbumEntry album)
        {
            if(! _badAlbums.Contains(album))
            {
                _badAlbums.Add(album);
            }
        }

         public override List<SongEntry> GetAllSongs()
        {
            return this._badSongs;
        }
        public override List<AlbumEntry> GetAllAlbums() 
        {
            return this._badAlbums;
        }
        

    }
}