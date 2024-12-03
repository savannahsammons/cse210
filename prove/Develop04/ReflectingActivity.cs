
using System.Diagnostics;
using System.Xml;

class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>{"-- Think of a time when you did something really difficult --", "-- Think of a time when you overcame something --"};
    List<string> _questions = new List<string>{"> How did you feel when it was complete? ", "> How did you feel about the experience? ", "> How did you feel about everything? "};
    // _prompts = ["-- Think of a time when you did something really difficult --", "-- Think of a time that you went through something really hard --"];
    public ReflectingActivity(): base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){}

    public void SetDuration(int duration)
    {
        _duration = duration; // Set the duration dynamically
    }

    private List<string> GetRandomPrompt()
    {

        return _prompts;
    }

    public void Prompt()
    {

        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayReflecting()
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
        for (int i = 0; i< _duration/15;i++)
        {
            Console.Write(_questions[i]);
            for (int j = 0; j < 5; j++)
            {
                Spinner();
                Spinner();
                Spinner();
            }
        }
    }
}