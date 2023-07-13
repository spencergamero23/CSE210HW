using System;

namespace Develop05
{
    public class SimpleGoal : Goal
    {
        private bool _completed = false;
        public SimpleGoal()
        {
        }
        public SimpleGoal(string[] arr) : base(arr)
        {
            
        }
        public override void ConvertToString()
        {
            Console.WriteLine($"[{(_completed ? "X" : " ")}] {_goalName} ({_goalDescription})");
        }

        public override string ConvertToStringForFile()
        {
            return $"SimpleGoal:{_goalName},{_goalDescription},{_points},{_completed}";
        }
        public override void MarkComplete(ref int totalPoints)
        {
            if(!_completed)
            {
                _completed = true;
                totalPoints += _points;
            }
            else
            {
                Console.WriteLine("You already finished this, stop milking it.");
            }
        }
    }
}