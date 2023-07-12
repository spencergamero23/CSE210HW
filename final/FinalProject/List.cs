using System;
namespace FinalProject
{
    public abstract class List
    {
        public abstract void AddSong(SongEntry song); 
        public abstract void AddAlbum(AlbumEntry album);
        
        public abstract List<SongEntry>GetAllSongs();
        public abstract List<AlbumEntry> GetAllAlbums();

    }
}