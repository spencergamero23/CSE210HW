using System;

class Program
{
    static void Main(string[] args)
    {
        console.write("What is your first name?");
        string first_name = console.readline();
        
        console.write("What is your last name?");
        string last_name = console.readline();

        console.writeline($"Your name is {last_name}, {first_name} {last_name}");
    }
}