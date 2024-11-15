
using System.ComponentModel.DataAnnotations;

class JournalEntry
{
    private List <string> entries = new List<string>();
    private string response;
    private Prompts _prompts;

    public JournalEntry()
    {
        _prompts = new Prompts();
    }
    public JournalEntry(int date, string prompt, string response)
    {
        Console.WriteLine($"{date}: Prompt- {prompt}");
        Console.WriteLine(response);
    }
    public void CreateEntryWithPrompt()
    {
        Console.Write(DateTime.Now.ToString("M/d/yyyy "));
        Console.WriteLine($"Prompt: {_prompts.NextQuestion()}");
        response = Console.ReadLine();
        entries.Add(response);
    }
}