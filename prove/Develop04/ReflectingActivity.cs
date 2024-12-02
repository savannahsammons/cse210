
using System.Diagnostics;
using System.Xml;

class ReflectingActivity : Activity
{
    public ReflectingActivity(): base("Reflecting", "This activity will help you reflect on times ...", 50){}

    public void DisplayTitle()
    {
        Console.WriteLine("description Reflect activity");
        Console.Write("How long? ");

        _duration = int.Parse(Console.ReadLine());
    }

    public void Prompt()
    {
        Console.WriteLine("--Name a time when ... --");
    }

    public void DisplayActivity()
    {
        Console.WriteLine("prompt: ...");

        Prompt();

        Console.WriteLine("When you have something in mind press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to the prompt...");

        Console.WriteLine("You may begin in...");
        Timer();
        
        Console.Clear();
    }

    public void DisplayQuestions()
    {
        Console.Write("> How did you feel when it was complete? ");
        for (int i = 0; i < 5; i++)
        {
            Spinner();
        }
        Console.Write("> How did you feel about the experience? ");
        for (int i = 0; i < 5; i++)
        {
            Spinner();
        }
    }


}