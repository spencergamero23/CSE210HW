using System;
namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            Favorite favorites = new Favorite();
            Dislike dislikes = new Dislike();
            Playlist playlist = new Playlist();
            Saver save = new Saver();
            Loader load = new Loader();
            EntryChoice choice = new EntryChoice();



            while(userInput != "6")
            {
                Console.WriteLine("Welcome to your own personal Music Library!");
                Console.WriteLine();
                Console.WriteLine("Would you like to: ");
                Console.WriteLine(" 1. Enter a song");
                Console.WriteLine(" 2. Enter an album");
                Console.WriteLine(" 3. Make a playlist");
                Console.WriteLine(" 4. Save");
                Console.WriteLine(" 5. Load");
                Console.WriteLine(" 6. Quit");
                
                userInput = Console.ReadLine();

                if(userInput == "1")
                {
                    choice.Choose(userInput,favorites,dislikes);
                }
                else if(userInput == "2")
                {
                    choice.Choose(userInput,favorites,dislikes);
                }
                else if(userInput == "3")
                {
                    playlist.BuildPlaylist(favorites);
                }
                else if(userInput == "4")
                {
                    save.SaveSongs(favorites,dislikes);
                    save.SaveAlbums(favorites,dislikes);
                }
                else if(userInput == "5")
                {
                    load.LoadFavSongs(favorites);
                }
                else if(userInput == "6")
                {
                    Console.WriteLine("Thanks for participating!");
                }
                else
                {
                    Console.WriteLine("ERROR INCORRECT INPUT");
                }




            }
        }
    }
}