using System;
namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment("Spencer Gamero", "Fractions");
            
            Console.WriteLine(assignment.GetSummary());

            MathAssignment ma = new MathAssignment("Bingus", "Fractions","7.3","8-19");

            Console.WriteLine(ma.GetSummary());
            Console.WriteLine(ma.GetHomeworkList());

            WritingAssignment wa = new WritingAssignment("Chungus", "History", "The Causes of World War II");
            Console.WriteLine(wa.GetSummary());
            Console.WriteLine(wa.GetWritingInformation());
            
        }
    }
}