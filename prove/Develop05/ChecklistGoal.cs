
class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, string description, int points, int times, int bonusPoints) : base(name, description, points)
    {
        // idk
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }
}