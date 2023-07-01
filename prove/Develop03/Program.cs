using System;

namespace Develop03 {
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            string mosiahFour = "And also, ye yourselves will asuccor those that stand in need of your succor; ye will administer of your substance unto him that standeth in need; and ye will not suffer that the beggar putteth up his petition to you in vain, and turn him out to perish.";

            Reference reference = new Reference("Mosiah", 4, 16);
            Scripture scripture = new Scripture(reference, mosiahFour);

            while(!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetRenderedText());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or 'quit' to finish: ");
                input = Console.ReadLine();
                if(input == "")
                {   
                    scripture.HideWords();
                    Console.Clear();
                }
                else if (input == "quit")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR, INCORRECT INPUT");
                }
            }
            Console.WriteLine(scripture.GetRenderedText());
        }
    }

}