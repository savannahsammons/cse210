
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

    private int PickRandomNum()
    {
        Random rand = new Random();
        int randomNum = rand.Next(0,5);
        return randomNum;
    }
    public string PickName(List<string> names)
    {
        int randomNum = PickRandomNum();
        string name = names[randomNum];
        return name;
    }
}