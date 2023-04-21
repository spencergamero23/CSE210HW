using System;

class Program
{
    static void Main(string[] args)
    {
        console.write("What is your grade percentage?");
        string userGrade = console.readline();

        int grade = int.parse(userGrade);
        string letter = ""

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B"
        }
        else if (grade >=70)
        {
            letter = "C"
        }
        else if (grade >= 60)
        {
            letter = "D"
        }
        else
        {
            letter = "F"
        }

        console.writeline($"You got a {letter}")

        if (grade >= 70)
        {
            console.writeline("You passed the class!")
        }
        else
        {
            console.writeline("You failed")
        }
    }
}