
abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status; // maybe...

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public virtual void DisplayGoals(List<Goal> goals)
    {
        int i = 0;
        Console.WriteLine("The goals are:");
        foreach (Goal g in goals)
        {
            i++;
            Console.WriteLine($"{i}. [{IsComplete}] {_name} ({_description})");
        }
    }
    public virtual void RecordEvent()
    {
        // idk
    }
    public virtual bool IsComplete()
    {
        return false;
    }

    public abstract void RunGoal();
    // public virtual string[] ListGoal(string filename)
    // {
    //     // idk
    // }

    // public virtual string ListAllGoals()
    // {

    // }

}