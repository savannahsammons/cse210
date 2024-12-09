
using System.ComponentModel;
using System.IO.Enumeration;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        // _name = name;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    // public override string ToString()
    // {
    //     // string newString = $"{name}|{description}|{points}";
    //     // return newString;
    // }

    public override void ListGoal(string filename)
    {
        base.ListGoal(filename);
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string name = parts[0];
                string description = parts[1];
                string points = parts[2];
            }
    }
}