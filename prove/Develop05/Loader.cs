using System;

namespace Develop05
{
    public class Loader
    {

         public static void LoadGoals(List<Goal> goals, ref int points)
        {
            Console.Write("Name of file?");
            string FileName = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(FileName);

            for(int i = 0; i <lines.Length; i++)
            {
                if (i == 0)
                {
                    points = int.Parse(lines[i]);
                }
                else
                {
                    string[] parts = lines[i].Split(":");
                    string type = parts[0];
                    string args = parts[1];
                    string[] assets = args.Split(",");

                    Goal goal;
                    if(type == "SimpleGoal")
                    {
                        goal = new SimpleGoal(assets);
                    }
                    else if(type == "EternalGoal")
                    {
                        goal = new EternalGoal(assets);
                    }
                    else if(type == "CheckListGoal")
                    {
                        goal = new ChecklistGoal(assets);
                    }
                    else
                    {
                        Console.WriteLine("ERROR SOMETHING WENT WRONG");
                        continue;
                    }
                    
                    goals.Add(goal);
                }
                
            }
        }
    }
}