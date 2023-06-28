using System;
using System.Collections.Generic;
namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string userResponse = "";


            //For the journal function
            Journal journal = new Journal();
            //For getting prompts
            Prompts prompts = new Prompts();
            //date
            DateTime theCurrentTime = DateTime.Now;
            //for the write function
            //For the Display function
             Display display = new Display();
            //for the load function
            Loader loader = new Loader();
            //for the Save function
            Saver saver = new Saver();

            while(input != "Quit" || input != "5")
            {
                Console.WriteLine("Welcome to the Journal Program!");
                Console.WriteLine("Please select one of the following choices");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("What would you like to do? ");

                input = Console.ReadLine();
                

                if(input == "Write" || input == "1")
                {
                    string prompt = prompts.GetRandomPrompt();

                    string date = theCurrentTime.ToShortDateString();

                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    userResponse = Console.ReadLine();
                    Entry userEntry = new Entry();
                    userEntry.Hold(prompt,userResponse,date);

                    journal.AddEntry(userEntry);
                }
                else if(input == "Display" || input == "2")
                {
                    display.DisplayEntries(journal);
                }
                else if(input == "Load" || input =="3")
                {
                    loader.LoadJournal(journal);
                }
                else if(input == "Save" || input == "4")
                {
                    saver.SaveJournal(journal);
                }
                else if(input == "Quit" || input =="5")
                {
                    Console.WriteLine("See you next time!");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            
            }
        }
    }
}
