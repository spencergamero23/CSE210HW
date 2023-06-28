using System;
namespace Develop03
{
    public class Display
    {
        public void Display_References(Reference reference, Word word)
        {
            Console.WriteLine($"{reference._book} {reference._chapter}:{reference._verseTo}");
            Console.WriteLine(word._word);            
        }
        // public bool getFunction()
        // {
        //    string input = Console.ReadLine();

        //     do
        //     {
        //         if (input == "")
        //         {
                    
        //         }
        //         else if (input == "quit")
        //         {

        //         }
        //         else
        //         {
        //             Console.WriteLine("ERROR TRY AGAIN");
        //         }   
        //     }while (input != "quit");

        // }
    }
}