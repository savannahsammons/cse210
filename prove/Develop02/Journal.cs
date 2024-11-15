
using System.ComponentModel.DataAnnotations;

class JournalEntry
{
    private List <string> entries = new List<string>();
    private Prompts prompts;

    public JournalEntry()
    {
        prompts = new Prompts();
    }
    public JournalEntry(int date, string prompt, string response)
    {
        Console.WriteLine($"{date}: Prompt- {prompt}");
        Console.WriteLine(response);
    }
    public void CreateEntryWithPrompt()
    {
        Console.WriteLine(prompts.NextQuestion());
    }
}