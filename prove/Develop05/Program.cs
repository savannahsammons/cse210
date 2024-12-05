using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        Menu menu1 = new Menu();

        List<Goal> goal = new List<Goal>();

        menu1.DisplayMainMenu();
        int goalType = menu1.SetAndGetMenuChoice();

        while (true)
        {
            if (goalType == 1)
            {
                // Console.WriteLine("1st choice");
                menu1.TypeOfGoalMenu();
            }
        }
    }
}