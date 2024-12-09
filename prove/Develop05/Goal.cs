
class Goal
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
    public virtual void DisplayGoals()
    {
        // idk yet
    }
    public virtual void RecordEvent()
    {
        // idk
    }
    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual void RunGoal()
    {
        // idk
    }
    public virtual void ListGoal(string filename)
    {
        // idk
    }

}