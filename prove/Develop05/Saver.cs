 using System;

namespace Develop05
{
    public class Saver
    {
        public static void SaveGoals(List<Goal> goals, int points)
        {
            Console.Write("Name of file?");
            string FileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(FileName))
            {
                outputFile.WriteLine(points);

                foreach (Goal goal in goals)
                {
                    string data = goal.ConvertToStringForFile();
                    outputFile.WriteLine(data);
                }
            }
        }
    }
}