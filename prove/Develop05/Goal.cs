using System;

namespace Develop05
{
    public class Goal
    {
        private List<Goal> goals = new List<Goal>();
        private string _goalDescription;
        private string _goalName;
        private int _currentPoints;
        private int _points;

        public string CurrentPoints(int points)
        {
            _points = points;

            return $"You have {_points} points.";
        }

        public virtual string AssignName()
        {
            Console.WriteLine("What is the goal? ");
            _goalName = Console.ReadLine();
            return _goalName;
        }

        public virtual string AssignDescription()
        {
            Console.WriteLine("What is a short description of it? ");
            _goalDescription = Console.ReadLine();
            return _goalDescription;
        }
        

        
    }
}