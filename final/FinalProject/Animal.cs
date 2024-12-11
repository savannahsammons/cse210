
abstract class Animal
{
    private string _name;
    private string _sound;
    private List<string> pigNames = ["Miss Piggy", "Porkchop", "Chubby", "Pumbaa", "Buttons"];
    private List<string> cowNames = ["", "", "", "", ""];
    private List<string> goatNames = ["", "", "", "", ""];
    private List<string> chickenNames = ["", "", "", "", ""];
    private List<string> alpacaNames = ["", "", "", "", ""];
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

    private int PickRandomName()
    {
        Random rand = new Random();
        int randomNum = rand.Next(0,5);
        return randomNum;
    }
}