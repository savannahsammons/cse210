
class Goat : Animal
{
    public Goat(string type, string name, string sound) : base(type, name, sound){}

    public override void MakeSound()
    {
        Console.WriteLine(GetAnimalSound());
    }
}