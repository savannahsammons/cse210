
class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status; // maybe...

    // public virtual CreateNewGoal() : Goal
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

}