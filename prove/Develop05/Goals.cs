
class Goals
{
    List<Goal> goals = new List<Goal>();
    int totalPoints = 0;
    public void PromptUser()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What are the points associated with the goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        // SimpleGoal simp = new SimpleGoal(goalName, goalDescription, goalPoints);
        // goals.Add(simp);

        Console.WriteLine($"You have {totalPoints} points.");
    }
}