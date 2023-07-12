using System;
namespace FinalProject
{
    public class Favorite : List
    {
        private List<SongEntry> _favSongs;
        private List<AlbumEntry> _favAlbums;

        public Favorite()
        {
            _favSongs = new List<SongEntry>();
            _favAlbums = new List<AlbumEntry>();
        }
        public override void AddSong(SongEntry song)
        {
            if(! _favSongs.Contains(song))
            {
                _favSongs.Add(song);
            }
        }
        public override void AddAlbum(AlbumEntry album)
        {
            if(! _favAlbums.Contains(album))
            {
                _favAlbums.Add(album);
            }
        }
        public override List<SongEntry> GetAllSongs()
        {
            return this._favSongs;
        }
        public override List<AlbumEntry> GetAllAlbums() 
        {
            return this._favAlbums;
        }

        public int FavoriteSongCount()
        {
            int numFavSongs = _favSongs.Count;
            
            return numFavSongs;
        }


        

    }
}