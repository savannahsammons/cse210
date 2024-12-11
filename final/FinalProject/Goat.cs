
class Goat : Animal
{
    private List<string> goatNames = ["", "", "", "", ""];
    public Goat(string type, string name, string sound) : base(type, name, sound)
    {
        // idk
    }

    public override void MakeSound()
    {
        throw new NotImplementedException();
    }
}