using System;

namespace Develop03 {
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            string mosiahFour = "And also, ye yourselves will asuccor those that stand in need of your succor; ye will administer of your substance unto him that standeth in need; and ye will not suffer that the beggar putteth up his petition to you in vain, and turn him out to perish.";

            Reference reference = new Reference("Mosiah", 4, 16);
            Word word = new Word(mosiahFour);
            Display display = new Display();
            Scripture scripture = new Scripture(reference, word);

            do{
                input = Console.ReadLine();

                if(input == "")
                {
                    scripture.hidewords();
                    Console.Clear();

                }
                Console.Clear();
                display.Display_References(reference, word);
            } while (input!= "quit"); 
        }
    }

}