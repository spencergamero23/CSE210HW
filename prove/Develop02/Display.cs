using System;
namespace Develop02
{
    public class Display
    {
        
        public void DisplayEntries(Journal journal)
        {
            foreach(Entry entry in journal.GetAllEntries())
            {
                string data = entry.ConvertToString();
                    Console.WriteLine(data);
            }
        }
    }
}