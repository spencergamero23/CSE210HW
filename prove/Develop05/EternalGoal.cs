using System;

namespace Develop05
{
    public class EternalGoal : Goal
    {
        public EternalGoal()
        {
        }
        public EternalGoal(string[] arr) : base(arr)
        {
            
        }

        public override void ConvertToString()
        {
            Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
        }
         public override string ConvertToStringForFile()
        {
            return $"EternalGoal:{_goalName},{_goalDescription},{_points}";
        }
        public override void MarkComplete(ref int totalPoints)
        {
            totalPoints += _points;
        }
    }
}