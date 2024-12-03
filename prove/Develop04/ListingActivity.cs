
class ListingActivity : Activity
{
    public ListingActivity(): base("Listing", "Description of listing..."){}

    public void SetDuration(int duration)
    {
        _duration = duration; // Set the duration dynamically
    }

    public void DisplayListing()
    {
        Console.WriteLine("List as many responses as you can to the following prompt...");

    }
    
}