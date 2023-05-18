using System;
using System.IO;
namespace Develop02
{
    public class Saver
    {
        public void SaveJournal(Journal journal)
        {
            Console.Write("Name of file?");
            string FileName = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(FileName))
            {
                //here we would out the lines form the list. So we would most likely have to cycle through a for each loop writing every entry into the file.//
                foreach (Entry entry in journal.GetAllEntries() )
                {
                    string data = entry.ConvertToStringForFile();
                    outputFile.WriteLine(data);
                    
                }
            }
        }
    }
}