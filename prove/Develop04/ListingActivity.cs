
class ListingActivity : Activity
{
    private List<string> prompts = new List<string>{"-- When have you felt the Holy Ghost this month? --", "-- When have you felt the Saviors love this week? --", "-- When have you served others today? --"};
    private List<string> responses = new List<string>{};
    public ListingActivity(): base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things you can in a certain area."){}

    public void SetDuration(int duration)
    {
        _duration = duration; // Set the duration dynamically
    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int num = rnd.Next(0, prompts.Count());
        string prompt = prompts[num];
        return prompt;
    }

    public void DisplayListing()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.WriteLine("You may begin in...");
        Timer();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (true)
        {
            DateTime currentTime = DateTime.Now;
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            
            if (currentTime > futureTime)
            {
                break;
            }
        }

        int listLength = responses.Count();
        Console.WriteLine($"You Listed {listLength} items!");
        Console.WriteLine("");
    }
    
}