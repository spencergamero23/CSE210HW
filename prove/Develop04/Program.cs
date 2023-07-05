using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            string bMessage = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
            string rMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            string lMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            string input = "";
            string actInput = "";
            int seconds = 0;

            BreathingActivities breathing = new BreathingActivities();
            ReflectionActivities reflection = new ReflectionActivities();
            ListingActivities listing = new ListingActivities();
            
            while(input != "4")
            {
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflection Activity");
                Console.WriteLine("3. Start Listening Activity");
                Console.WriteLine("4. Quit");

                input = Console.ReadLine();

                if (input == "1")
                {   
                    Console.Clear();
                    Console.WriteLine("Welcome to the Breathing Activity");
                    Console.WriteLine(breathing.SayActivity(bMessage));
                    Console.WriteLine("How long in seconds, would you like for your session? ");
                    actInput = Console.ReadLine();
                    seconds = int.Parse(actInput);
                    breathing.Timer(seconds, input, breathing, reflection, listing);

                }
                else if(input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Reflection Activity");
                    Console.WriteLine(reflection.SayActivity(rMessage));
                    Console.WriteLine("How long in seconds, would you like for your session? ");
                    actInput = Console.ReadLine();
                    seconds = int.Parse(actInput);
                    reflection.Timer(seconds, input, breathing, reflection, listing);

                }
                else if (input == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Breathing Activity");
                    Console.WriteLine(breathing.SayActivity(lMessage));
                    Console.WriteLine("How long in seconds, would you like for your session? ");
                    actInput = Console.ReadLine();
                    seconds = int.Parse(actInput);
                    listing.Timer(seconds, input, breathing, reflection, listing);
                }
                else if (input == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for participating");
                }
                else
                {
                    Console.WriteLine("ERROR INCORRECT INPUT");
                }
            
            }
        }
    }
}