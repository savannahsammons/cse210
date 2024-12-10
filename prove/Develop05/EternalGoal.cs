
class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        // idk
    }
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