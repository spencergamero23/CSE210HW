using System;
using System.Collections.Generic;
namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Entry myEntry = new Entry();
            myEntry.Hold("What is your name?","Matthew Manley","8 May 2023");
            Entry yourEntry = new Entry();
            yourEntry.Hold("What is your favorite food?", "Anything I don't make", "8 May 2023");


            Journal journal = new Journal();
            journal.AddEntry(myEntry);
            journal.AddEntry(yourEntry);

            List<Entry> entries = journal.GetAllEntries();
            foreach (Entry entry in entries)
            {
                string message= entry.ConvertToString();
                Console.WriteLine(message);
            }
        }
    }
}
