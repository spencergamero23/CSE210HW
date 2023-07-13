using System;

namespace Develop05
{
    public class ChecklistGoal : Goal
    {
        private int _repititions = 0;
        private int _completedRepititions = 0;
        private int _bonus = 0;

        public ChecklistGoal()
        {
        }
        public ChecklistGoal(string[] arr) : base(arr)
        {
            _bonus = int.Parse(arr[3]);
            _repititions = int.Parse(arr[4]);
            _completedRepititions = int.Parse(arr[5]);
        }
        public int AssignRepitions()
        {
            Console.WriteLine("How many times until this is completed? ");
            string amount = Console.ReadLine();
            _repititions = int.Parse(amount);
            return _repititions;
        }
        public int AssignBonus()
        {
            Console.WriteLine("How many points should this have once completed? ");
            string points = Console.ReadLine();
            _bonus = int.Parse(points);
            return _bonus;
        }
        public override string ConvertToStringForFile()
        {
            return $"CheckListGoal:{_goalName},{_goalDescription},{_points},{_bonus},{_repititions},{_completedRepititions}";
        }
        public override void ConvertToString()
        {
            Console.WriteLine($"[{(_completedRepititions == _repititions ? "X" : " ")}] {_goalName} ({_goalDescription}) -- Currently Completed {_completedRepititions}/{_repititions}");
        }
        public override void MarkComplete(ref int totalPoints)
        {
            if (_completedRepititions <_repititions)
            {
                _completedRepititions++;
                totalPoints += _points;
                if(_completedRepititions == _repititions)
                {
                    totalPoints+=_bonus;
                }
            }
            else
            {
                Console.WriteLine("You're already done, stop milking it");
            }
        }
    }
}