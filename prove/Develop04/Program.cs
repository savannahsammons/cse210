using System;

class Program
{
    static void Main(string[] args)
    {
        Activity act = new Activity();
        BreathingActivity ba = new BreathingActivity();

        act.DisplayMenu();
        act.Spinner();

        ba.DisplayGetReady();
        ba.DisplayBreathing();
    }
}