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
    static void Main(string[] args)
    {
        
        // journal program
    }
}