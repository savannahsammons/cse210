using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Activity act = new Activity();
        // BreathingActivity ba = new BreathingActivity();
        // ReflectingActivity ra = new ReflectingActivity();
        // ListingActivity la = new ListingActivity();

        while (true)
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            int menuChoice = int.Parse(Console.ReadLine());

            Console.Clear();

            // Console.WriteLine("Get Ready...");
            // for (int i = 0;i < 3;i++)
            // {
            //     Spinner();
            // }

            if (menuChoice == 1)
            {
                BreathingActivity ba = new BreathingActivity();
                ba.DisplayTitle();
                int duration = ba.FindDuration();
                ba.SetDuration(duration);
                ba.DisplayGetReady();
                ba.DisplayBreathing();
                ba.DisplayOutro();
            }
            if (menuChoice == 2)
            {
                ReflectingActivity ra = new ReflectingActivity();
                ra.DisplayTitle();
                int duration = ra.FindDuration();
                ra.SetDuration(duration);
                ra.DisplayGetReady();
                ra.DisplayReflecting();
                ra.DisplayQuestions();
                ra.DisplayOutro();
            }
            if (menuChoice == 3)
            {
                ListingActivity la = new ListingActivity();
                la.DisplayTitle();
                int duration = la.FindDuration();
                la.SetDuration(duration);
                la.DisplayGetReady();
                la.DisplayListing();
                la.DisplayOutro();
            }
            if (menuChoice == 4)
            {
                break;
            }
        }
    }
}