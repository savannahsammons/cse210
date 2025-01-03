
using System.ComponentModel;
using System.IO.Enumeration;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {}

    // public override string ToString()
    // {
    //     // string newString = $"{name}|{description}|{points}";
    //     // return newString;
    // }

    public string[] ListGoal(string filename)
    {
        // base.ListGoal(filename);
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string name = parts[0];
                string description = parts[1];
                string points = parts[2];
            }
        return lines;
    }

    public override void DisplayGoals(List<Goal> goals)
    {
        base.DisplayGoals(goals);
    }
    public override void RunGoal()
    {
        throw new NotImplementedException();
    }

    public override void ListGoal()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}