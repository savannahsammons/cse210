
using System.Security.Cryptography;

abstract class Animal
{
    private string _type;
    private string _name;
    private string _sound;
    public Animal(string type, string name, string sound)
    {
        _type = type;
        _name = name;
        _sound = sound;
    }

    public abstract void MakeSound();

    public string GetAnimalType()
    {
        return _type;
    }
    public string GetAnimalName()
    {
        return _name;
    }
    public string GetAnimalSound()
    {
        return _sound;
    }
}