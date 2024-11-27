
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
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");
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