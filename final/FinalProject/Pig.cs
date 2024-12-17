
class Pig : Animal
{
    public Pig(string type, string name, string sound) : base(type, name, sound){}
    public override void MakeSound()
    {
        Console.WriteLine(GetAnimalSound());
    }
}