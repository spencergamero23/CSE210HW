using System;
namespace Develop04
{
    public class ListingActivities : Activities
    {
        private List<string> _listPrompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        private List<string> _responses = new List<string>{};

        public ListingActivities()
        {

        }

        public void AddResponse(string response)
        {
            this._responses.Add(response);
        }
        public void ListResponsePrompt()
        {
            Random rndmStartPrompt = new Random();
            int index = rndmStartPrompt.Next(0,4);
            Console.WriteLine($"-- {_listPrompts[index]} --");
        }

    }
}