using System;
namespace FinalProject
{
    public class EntryChoice
    {
        public void Choose(string userInput, Favorite favorite, Dislike dislike)
        {
            string name = "";
            string artist = "";
            if (userInput == "1")
            {
                Console.WriteLine("What is the name of the song?");
                name = Console.ReadLine();
                Console.WriteLine("Who's the artist? ");
                artist = Console.ReadLine();
                SongEntry song = new SongEntry();
                song.Hold(name,artist);
                Console.WriteLine("Did you like this song? Y/N ");
                userInput = Console.ReadLine();

                if(userInput.ToLower() == "y")
                {
                    favorite.AddSong(song);
                }
                else if (userInput.ToLower() == "n")
                {
                    dislike.AddSong(song);
                }
                else
                {
                    Console.WriteLine("ERROR INCORRECT INPUT");
                }
            }
             else if (userInput == "2")
            {
                Console.WriteLine("What is the name of the Album?");
                name = Console.ReadLine();
                Console.WriteLine("Who's the artist? ");
                artist = Console.ReadLine();
                AlbumEntry album = new AlbumEntry();
                album.Hold(name,artist);
                Console.WriteLine("Did you like this song? Y/N ");
                userInput = Console.ReadLine();

                if(userInput.ToLower() == "y")
                {
                    favorite.AddAlbum(album);
                }
                else if (userInput.ToLower() == "n")
                {
                    dislike.AddAlbum(album);
                }
                else
                {
                    Console.WriteLine("ERROR INCORRECT INPUT");
                }
            }
        }
    }
}