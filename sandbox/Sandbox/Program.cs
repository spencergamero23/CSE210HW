using System;

class Program
{
    static void Main(string[] args)
    {

        for (int i = 0; i < 5; i++)
            {
                Console.Write("|"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("/"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("-"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("\\"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("|"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        

    }
}