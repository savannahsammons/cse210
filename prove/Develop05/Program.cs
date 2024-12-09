using System;
using System.Data;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        Menu menu1 = new Menu();
        List<Goal> goals = new List<Goal>();

        int totalPoints = 0;

        string filename = "goals.txt";

        menu1.DisplayMainMenu();
        int menuChoice = menu1.SetAndGetMenuChoice();

        while (true)
        {
            if (menuChoice == 1)
            {
                // Console.WriteLine("1st choice");
                menu1.TypeOfGoalMenu();
                int goalType = menu1.SetAndGetMenuChoice();
                if (goalType == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What are the points associated with the goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());
                    SimpleGoal simp = new SimpleGoal(goalName, goalDescription, goalPoints);
                    goals.Add(simp);

                    Console.WriteLine($"You have {totalPoints} points.");
                }
                if (goalType == 2)
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What are the points associated with the goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());
                    EternalGoal eternal = new EternalGoal(goalName, goalDescription, goalPoints);
                    goals.Add(eternal);

                    Console.WriteLine($"You have {totalPoints} points.");
                }
                if (goalType == 3)
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What are the points associated with the goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());
                    Console.Write("How many times does the goal need to be accomplished for a bonus? ");
                    int totalTimes = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int totalBonus = int.Parse(Console.ReadLine());
                    ChecklistGoal check = new ChecklistGoal(goalName, goalDescription, goalPoints, totalTimes, totalBonus);
                    goals.Add(check);

                    Console.WriteLine($"You have {totalPoints} points.");
                }
            }
            if (menuChoice == 2)
            {
                Console.WriteLine(goals);
            }
            if (menuChoice == 3)
            {
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(totalPoints);
                    outputFile.WriteLine(goals);
                }
            }
            if (menuChoice == 4)
            {
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");

                    string name = parts[0];
                    string description = parts[1];
                    string points = parts[2];
                }
            }
            if (menuChoice == 5)
            {
                // idk
            }
            if (menuChoice == 6)
            {
                break;
            }
        }
    }
}