
class BreathingActivity : Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public BreathingActivity()
    {
        // idk yet
    }

    public void DisplayTitle()
    {
        Console.WriteLine("Welcome to the Breathing Activity");

        Console.Write("What is duration? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
    }

    public void DisplayGetReady()
    {
        Console.WriteLine("Get Ready...");
        for (int i = 0;i < 5;i++)
        {
            Spinner();
        }
    }

    public void DisplayBreathing()
    {
        Console.WriteLine("Breathe in...");

        Console.WriteLine("Now breathe out...");
    }
}