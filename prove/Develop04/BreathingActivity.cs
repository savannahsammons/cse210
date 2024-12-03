
using System.Xml;

class BreathingActivity : Activity
{
    public BreathingActivity(): base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."){}

    public void SetDuration(int duration)
    {
        _duration = duration; // Set the duration dynamically
    }
    public void DisplayBreathing()
    {
        for (int i = 0; i< _duration/12;i++)
        {
            Console.WriteLine("");
            Console.Write("Breathe in...");

            Timer();

            Console.WriteLine("");
            Console.Write("Now breathe out...");

            Timer();

            Console.WriteLine("");
            // Console.WriteLine("");
        }
    }
}