using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(UserNumber);

        Displayresult(userName, SquaredNumber);
    
    }



        //Functions
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Give me a number. ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            return inputNumber;
        }
        static int SquareNumber(int inputNumber)
        {
            int square = inputNumber *inputNumber;
            return square;
        }
        static void Displayresult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
}