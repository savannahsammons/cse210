
abstract class Animal
{
    private string _name;
    private string _sound;
    public Animal(string name, string sound)
    {
        _name = name;
        _sound = sound;
    }

    public void DisplayAnimals()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_sound);
    }

    public abstract void MakeSound();
}