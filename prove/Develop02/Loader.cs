namespace Develop02
{
    public class Loader
    {
         public void LoadJournal(Journal journal)
        {
            Console.Write("Name of file?");
            string FileName = Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines(FileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");

                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry myEntry = new Entry();
                    myEntry.Hold(prompt,response,date);
                    
                    journal.AddEntry(myEntry);
                }

    
        }
    }
}