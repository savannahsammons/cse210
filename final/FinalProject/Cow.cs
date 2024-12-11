

class Cow : Animal
{
    private List<string> cowNames = ["", "", "", "", ""];
    public Cow(string type, string name, string sound) : base(type, name, sound)
    {
        // idk yet
    }
    public override void MakeSound()
    {
        throw new NotImplementedException();
    }
}