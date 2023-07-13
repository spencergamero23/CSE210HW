using System;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Goal> goals = new List<Goal>();
            string userInput = "";
            int points = 0;
            while( userInput != "6")
            {
                Console.WriteLine($"Total points: {points}");
                Console.WriteLine("Menu Options:");
                Console.WriteLine(" 1. Create New Goal");
                Console.WriteLine(" 2. List Goals");
                Console.WriteLine(" 3. Save Goals");
                Console.WriteLine(" 4. Load Goals");
                Console.WriteLine(" 5. Record Event");
                Console.WriteLine(" 6. Quit");

                Console.WriteLine("Select a choice from a menu: ");
                userInput = Console.ReadLine();

                if(userInput == "1")
                {
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");
                    userInput = Console.ReadLine();
                    if(userInput == "1")
                    {
                        SimpleGoal simple = new SimpleGoal();
                        simple.AssignName();
                        simple.AssignDescription();
                        simple.AssignPoints();
                        goals.Add(simple);
                        
                    }
                    else if(userInput == "2")
                    {
                        EternalGoal eternal = new EternalGoal();
                        eternal.AssignName();
                        eternal.AssignDescription();
                        eternal.AssignPoints();
                        goals.Add(eternal);
                    }
                    else if(userInput == "3")
                    {
                        ChecklistGoal checklist = new ChecklistGoal();
                        checklist.AssignName();
                        checklist.AssignDescription();
                        checklist.AssignPoints();
                        checklist.AssignRepitions();
                        checklist.AssignBonus();
                        goals.Add(checklist);
                    }
                    else
                    {
                        Console.WriteLine("ERROR TRY AGAIN");
                    }
                }
                else if(userInput == "2")
                {
                    foreach(Goal goal in goals)
                    {
                        goal.ConvertToString();
                    }
                }
                else if(userInput == "3")
                {
                    Saver.SaveGoals(goals, points);
                }
                else if(userInput == "4")
                {
                    Loader.LoadGoals(goals,ref points);
                }
                else if(userInput == "5")
                {
                    int counter = 0;
                    foreach(Goal goal in goals)
                    {
                        counter++;
                        Console.WriteLine($"{counter}. {goal.GoalName}");
                    }
                    Console.WriteLine("Which goal did you accomplish? ");
                    userInput = Console.ReadLine();
                    int index = int.Parse(userInput);
                    index -= 1;
                    if (index < goals.Count || index >= 0)
                    {
                        goals[index].MarkComplete(ref points);
                    }
                    else
                    {
                        Console.WriteLine("ERROR INCORRECT INPUT");
                    }
                }
                else if(userInput == "6")
                {
                    Console.WriteLine("Thanks for participating!");
                }
                else
                {
                    Console.WriteLine("ERROR INCORRECT INPUT");
                }

            }
        }
    }
}