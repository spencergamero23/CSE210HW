using System;
namespace Develop04
{
    public class Activities
    {
        public Activities()
        {

        }
        public string SayActivity(string message)
        {
            return $"{message}";
        }
        private void PrepUser()
        {

        }

        private void EndMessage()
        {

        }

        private void Animation()
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
                Console.Write("|"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        private void Timer(int seconds)
        {
            
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(seconds);

            Thread.Sleep(3000);

            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                Console.WriteLine("We have not arrived at our future time yet...");
            }
        }

    }
}