
using System.Xml;

class BreathingActivity : Activity
{
    public BreathingActivity(): base("Breathing", "This is the description...", 1000){}

    public void DisplayGetReady()
    {
        Console.WriteLine("Get Ready...");
        for (int i = 0;i < 3;i++)
        {
            Spinner();
        }
    }

    public void DisplayBreathing()
    {
        Console.WriteLine("");
        Console.Write("Breathe in...");

        Timer();

        Console.WriteLine("");
        Console.Write("Now breathe out...");

        Timer();
    }
}