using System;

namespace Develop05
{
    public abstract class Goal
    {
        protected string _goalDescription;
        protected string _goalName;
        protected int _points;
        public string GoalName => _goalName;
        

        public Goal()
        {
        }
        public Goal(string[] arr)
        {
            _goalName = arr[0];
            _goalDescription = arr[1];
            _points = int.Parse(arr[2]);
        }
        public string AssignName()
        {
            Console.WriteLine("What is the goal? ");
            _goalName = Console.ReadLine();
            return _goalName;
        }

        public string AssignDescription()
        {
            Console.WriteLine("What is a short description of it? ");
            _goalDescription = Console.ReadLine();
            return _goalDescription;
        }
        public int AssignPoints()
        {
            Console.WriteLine("How many points should this have? ");
            string points = Console.ReadLine();
            _points = int.Parse(points);
            return _points;
        }
        public void ConvertToFile(string name, string description, int points)
        {
            _goalName = name;
            _goalDescription = description;
            _points = points;
        }

        public abstract void ConvertToString();
        public abstract string ConvertToStringForFile();
        public abstract void MarkComplete(ref int totalPoints);
        

        
    }
}