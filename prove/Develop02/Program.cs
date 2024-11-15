using System;
using System.Security.Cryptography.X509Certificates;
using System.IO; 

class Program
{
    private static List<JournalEntry> entries = new List<JournalEntry>();
    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }
    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            
            // string date = parts[0];
            DateTime date = DateTime.Parse(parts[0]);
            string question = parts[1];
            string entryText = parts[2];

            JournalEntry entry = new JournalEntry(date, question, entryText);
            AddEntry(entry);
        }
    }
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

    static void Main(string[] args)
    {
        Program program = new Program();

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
                program.ReadFromFile(filename);
            }
            else if (menuSelection == 4)
            {
                Console.WriteLine("Please enter a filename to save your data.");
                Console.Write("> ");
                string filename = Console.ReadLine();
                program.WriteToFile(filename);
            }
            else if (menuSelection == 5)
            {
                _ifQuit = true;
            }
        }
    }
}