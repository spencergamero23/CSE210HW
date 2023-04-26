using System;

class Program
{
    static void Main(string[] args)
    {
        //First find the random number//
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        int userInput = 0;
        //1st ask user for random number//
       do{

        Console.Write("Enter your guess for the magic number ");
        userInput = Convert.ToInt32(Console.ReadLine());

        //Response if userInput is higher than magicNumber//
        if(userInput < magicNumber)
        {
            Console.WriteLine("Higher!");
        }
        //Response if userInput is higher than magicNumber//
        else if (userInput > magicNumber)
        {
            Console.WriteLine("Lower!");
        }
        
        //Creat while loop to continue asking for the magic number until it finds it!//
        } while (userInput != magicNumber);

        Console.WriteLine("You got it!");
    }
}