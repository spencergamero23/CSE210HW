using System;
namespace Develop04
{
    public class BreathingActivities : Activities
    {

        public BreathingActivities()
        {

        }

        public void Breathe()
        {
            Console.Write("Breathe in...");
            for (int i = 1; i < 5; i++)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }

            Console.WriteLine();

            Console.Write("Breath out...");
            for(int i = 1; i < 7; i++)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}