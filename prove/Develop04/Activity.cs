
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

        Thread.Sleep(5000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            int j = 5;
            Console.WriteLine("We have not arrived at our future time yet...");
            for (int i=0; i <= 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(j);
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
}