
using System.Diagnostics;
using System.Globalization;
using System.Runtime.ExceptionServices;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public void DisplayMenu()
    {
        Console.WriteLine("This will be the menu...");
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