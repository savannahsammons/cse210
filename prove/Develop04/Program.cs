using System;

class Program
{
    static void Main(string[] args)
    {
        // Activity act = new Activity();
        BreathingActivity ba = new BreathingActivity();
        ReflectingActivity ra = new ReflectingActivity();
        ListingActivity la = new ListingActivity();

        Console.WriteLine("This will be the menu...");

        ba.DisplayGetReady();
        ba.DisplayBreathing();
    }
}