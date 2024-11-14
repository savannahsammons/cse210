
using System.ComponentModel.DataAnnotations;

class JournalEntry
{
    private List <string> entries = new List<string>();

    public JournalEntry()
    {
        // idk
    }
    public JournalEntry(int date, string prompt, string response)
    {
        Console.WriteLine($"{date}: Prompt- {prompt}");
        Console.WriteLine(response);
    }

    public void DisplayAllEntries()
    {
    }

}