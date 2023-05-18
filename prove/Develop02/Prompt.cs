using System;

namespace Develop02
{
    // The resoponsibility of prompts is to hold a list of predetermind questions and provide a random one//
    public class Prompts
    {
        public List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};


       public string GetRandomPrompt()
        {
            Random rndmPrompt = new Random();

            int index = rndmPrompt.Next(0, 5);

            string prompt = prompts.ElementAt(index); 

            return prompt;

        }
    }
}