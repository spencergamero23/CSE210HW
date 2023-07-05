using System;
namespace Develop04
{
    public class Activities
    {
        private string command = "";
        private int counter = 0;
        private string response = "";
        public Activities()
        {

        }
        public string SayActivity(string message)
        {
            return $"{message}";
        }
        public void PrepUser()
        {

        }

        public void EndMessage(string actInput, int seconds)
        {
            if (actInput == "1")
            {
                Console.WriteLine("Well Done!!");
                Console.WriteLine();
                Console.WriteLine($"You have completed another {seconds} seconds of the Breathing Activity!");
            }
            else if(actInput == "2")
            {
                Console.WriteLine("Well Done!!");
                Console.WriteLine();
                Console.WriteLine($"You have completed another {seconds} seconds of the Response Activity!");
            }
            else if (actInput == "3")
            {
                Console.WriteLine("Well Done!!");
                Console.WriteLine();
                Console.WriteLine($"You have completed another {seconds} seconds of the Listing Activity!");
            }
            else
            {
                Console.WriteLine("ERROR TRY AGAIN");
            }
        }

        public void Animation()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("|"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("/"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("-"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("\\"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
            }
        }
        public void Timer(int seconds, string actInput, BreathingActivities breathing, ReflectionActivities reflection, ListingActivities listing)
        {
            int length = 0;

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(seconds);
            DateTime currentTime = DateTime.Now;

            Console.Clear();
            Console.WriteLine("Get Ready... ");

            Animation();

            length = seconds / 10;
            
            
            if (actInput == "1")
            {
                for(int i = 0; i<length; i++)
                {
                    breathing.Breathe();
                }
                EndMessage(actInput, seconds);
            }

            else if(actInput == "2")
            {
                reflection.ReflectStartPrompt();
                command = Console.ReadLine();
                if (command == "")
                {
                    reflection.Reflect(length);
                }
                else
                {
                    Console.WriteLine("ERROR SOMETHING WENT WRONG");
                }
                EndMessage(actInput, seconds);
            }

            else if (actInput == "3")
            {
                Console.WriteLine("List as many responses you can to the following prompt: ");
                listing.ListResponsePrompt();
                Console.Write("You may begin in: ");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

                while(currentTime < futureTime)
                {
                    counter++;
                    Console.WriteLine();
                    Console.Write(">");
                    response = Console.ReadLine();
                    listing.AddResponse(response);
                    currentTime = DateTime.Now;

                }
                Console.WriteLine($"You listed {counter} items!");
                Console.WriteLine();
                EndMessage(actInput, seconds);
            }
            else
            {
                Console.WriteLine("ERROR CODE IS UNSTABLE");
            }
            Animation();
            Console.Clear();
        }
    }
}