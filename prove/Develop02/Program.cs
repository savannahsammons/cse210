using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(JournalEntry entry in entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }
    public override string ToString()
    {
        string outPutString = "";
        outPutString = $"{date}#{_entryQuestion}#{_journalEntry}";
        return outPutString;
    }
    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            
            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            JournalEntry entry = new JournalEntry(date, question, entryText);
            this.AddEntry(entry);
        }
    }

    static void Main(string[] args)
    {
        bool _ifQuit = false;
        while (_ifQuit == false)
        {
            Menu newMenu = new Menu();

            newMenu.Display();
            int menuSelection = newMenu.ProcessMenu();
            if (menuSelection == 1)
            {
                JournalEntry myJournal = new JournalEntry();

                myJournal.CreateEntryWithPrompt();
            }
            else if (menuSelection == 2)
            {
                foreach(JournalEntry entry in entries)
                {
                    Console.WriteLine(entry);
                }
            }
            else if (menuSelection == 3)
            {
                Console.WriteLine("Please enter a filename to load your data");
                Console.Write("> ");
                string filename = Console.ReadLine();
                ReadFromFile(filename);
            }
            else if (menuSelection == 4)
            {
                Console.WriteLine("Please enter a filename to save your data.");
                Console.Write("> ");
                string filename = Console.ReadLine();
                WriteToFile(filename);
            }
            else if (menuSelection == 5)
            {
                _ifQuit = true;
            }
        }
    }
}