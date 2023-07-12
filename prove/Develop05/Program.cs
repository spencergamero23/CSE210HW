using System;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            Goal goal = new Goal();

            int points = 0;
            string userInput = "";

            while( userInput != "6")
            {
                Console.WriteLine(goal.CurrentPoints(points));
                Console.WriteLine("Menu Options:");
                Console.WriteLine(" 1. Create New Goal");
                Console.WriteLine(" 2. List Goals");
                Console.WriteLine(" 3. Save Goals");
                Console.WriteLine(" 4. Load Goals");
                Console.WriteLine(" 5. Record Event");
                Console.WriteLine(" 6. Quit");

                Console.WriteLine("Select a choice from a menu: ");
                userInput = Console.ReadLine();

                if(userInput == "1")
                {
                    goal.AssignName();
                }
                else if(userInput == "2")
                {

                }
                else if(userInput == "3")
                {

                }
                else if(userInput == "4")
                {

                }
                else if(userInput == "5")
                {

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