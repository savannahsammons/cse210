
using System.ComponentModel.DataAnnotations;

class JournalEntry
{
    private string date = DateTime.Now.ToString("M/d/yyyy ");
    private List <string> entries = new List<string>();
    private string response;
    private Prompts _prompts;
    private string _entryQuestion;
    // private string _journalEntry

    public JournalEntry()
    {
        _prompts = new Prompts();
        _entryQuestion = _prompts.NextQuestion();
    }
    public JournalEntry(DateTime date, string prompt, string response)
    {
        Console.WriteLine($"{date}: Prompt- {prompt}");
        Console.WriteLine(response);
    }
    public override string ToString()
    {
        string outPutString = "";
        outPutString = $"{date}#{_entryQuestion}#{response}";
        return outPutString;
    }
    public List<string> CreateEntryWithPrompt()
    {
        Console.WriteLine($"{date}: Prompt- {_entryQuestion}");
        response = Console.ReadLine();
        entries.Add(response);
        return entries;
    }
    public string Date()
    {
        return date;
    }
}