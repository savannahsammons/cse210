
abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = false;
    }

    public bool GetStatus()
    {
        return _status;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
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
    public override string ToString()
    {
        return $"{_name} ({_description})";
    }
    public abstract void RecordEvent();
    public virtual bool IsComplete()
    {
        return _status = true;
    }

    public abstract void RunGoal();

    public abstract void ListGoal();

}