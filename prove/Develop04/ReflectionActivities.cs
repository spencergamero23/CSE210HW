using System;
namespace Develop04
{
    public class ReflectionActivities : Activities
    {
        private List<string> _startPrompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult." ,"Think of a time when you helped someone in need." ,"Think of a time when you did something truly selfless."};
        private List<string> _endPrompts = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

        public ReflectionActivities()
        {
            
        }

        public void ReflectStartPrompt()
        {
            Random rndmStartPrompt = new Random();
            int index = rndmStartPrompt.Next(0,3);
            Console.WriteLine(_startPrompts[index]);
        }

        public void Reflect(int length)
        {
            Random rndmEndPrompt = new Random();
            for(int i =0; i < length; i++)
            {
                int index = rndmEndPrompt.Next(0,8);
                Console.WriteLine(_endPrompts[index]);
                Thread.Sleep(10000);
                base.Animation();
            }
        }

    }
}