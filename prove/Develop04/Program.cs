using System;

class Program
{
    static void Main(string[] args)
    {
        // Activity act = new Activity();
        // BreathingActivity ba = new BreathingActivity();
        ReflectingActivity ra = new ReflectingActivity();
        ListingActivity la = new ListingActivity();

        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            int menuChoice = int.Parse(Console.ReadLine());

            // Console.WriteLine("Get Ready...");
            // for (int i = 0;i < 3;i++)
            // {
            //     Spinner();
            // }

            if (menuChoice == 1)
            {
                BreathingActivity ba = new BreathingActivity();
                ba.DisplayTitle();
                ba.DisplayGetReady();
                ba.DisplayBreathing();
            }
            if (menuChoice == 2)
            {
                // reflecting activity
            }
            if (menuChoice == 3)
            {
                // listing activity
            }
            if (menuChoice == 4)
            {
                break;
            }
        }
    }
}