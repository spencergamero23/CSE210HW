using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {   int userNumber = 0; //the value of the number
        decimal loopCount = 0; // count of how many times it's looped
        int sum = 0; //sum of all the numbers
        int max = 0; // max of all the numbers
        decimal average = 0; //average of all the numbers
        List<int> userNumbers = new List<int>(); // list for the UserNumbers


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        do //while loop that won't stop until the user inputs 0
        {   Console.Write("Enter a number: ");
            userNumber = Convert.ToInt32(Console.ReadLine()); // converst the usernumber into an int
            userNumbers.Add(userNumber); // adds the usernumber to the list
        }while(userNumber != 0);


        foreach(int number in userNumbers)
        {
            loopCount += 1; // adds amount of loops to the loopcount
            sum = sum + number; //finds the total

            if (number > max) //where we find max
            {
                max = number;
            }
        }   

        average = (decimal)sum / loopCount; // find the average
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");


    }
}