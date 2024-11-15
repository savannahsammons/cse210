using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    // public void WriteToFile(string filename)
    // {
    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         foreach(JournalEntry entry in entries)
    //         {
    //             outputFile.WriteLine(entry.ToString());
    //         }
    //     }
    // }
    // public override string ToString()
    // {
    //     string outPutString = "";
    //     outputString = $"{date}#{_entryQuestion}#{_journalEntry}";
    //     return outputString();
    // }
    // public void ReadFromFile(string filename)
    // {
    //     string[] lines = System.IO.File.ReadAllLines(filename);
    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split("#");
            
    //         string date = parts[0];
    //         string question = parts[1];
    //         string entryText = parts[2];

    //         JournalEntry entry = new JournalEntry(date, question, entryText);
    //         this.AddEntry(entry);
    //     }
    // }

    static void Main(string[] args)
    {
        bool _ifQuit = false;
        while (_ifQuit == false)
        {
            Menu newMenu = new Menu();

            newMenu.Display();

            JournalEntry myJournal = new JournalEntry();

            myJournal.CreateEntryWithPrompt();
            
            _ifQuit = true;
        }
    }
}