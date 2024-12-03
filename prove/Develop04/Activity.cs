
using System.Diagnostics;
using System.Globalization;
using System.Runtime.ExceptionServices;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        // int number = int.Parse(Console.ReadLine());
        _duration = 0;
    }

    public int FindDuration()
    {
        int timeWanted = int.Parse(Console.ReadLine());
        // int _duration = int.Parse(Console.ReadLine());

        return timeWanted;
    }
    public void DisplayTitle()
    {
        Console.WriteLine($"Welcome to the {_name} Actvity!");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        // int timeWanted = int.Parse(Console.ReadLine());
        // return timeWanted;
    }

    public void DisplayGetReady()
    {
        Console.WriteLine("Get Ready...");
        for (int i = 0;i < 3;i++)
        {
            Spinner();
        }
    }

    public void Timer()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        DateTime currentTime = DateTime.Now;

        if (currentTime < futureTime)
        {
            int j = 5;
            for (int i=0; i <= 5; i++)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                j--;
            }
        }
    }
    public void Spinner()
    {
        Console.Write("|");

        Thread.Sleep(500);

        Console.Write("\b \b");

        Console.Write("/");
        
        Thread.Sleep(500);

        Console.Write("\b \b");

        Console.Write("-");
        
        Thread.Sleep(500);

        Console.Write("\b \b");

        Console.Write("\\");
        
        Thread.Sleep(500);

        Console.Write("\b \b");
    }

    public void DisplayOutro()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine("you finished blank...");
    }
}