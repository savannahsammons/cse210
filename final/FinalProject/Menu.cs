
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

class Menu
{
    
    public int DisplayMainMenu()
    {
        Console.WriteLine("=== Welcome to the Farm Simulation! ===\n");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Buy an animal");
        Console.WriteLine("2. Show my animals");
        Console.WriteLine("3. Quit");
        int choice = int.Parse(MenuChoice());
        return choice;
    }
    private string MenuChoice()
    {
        Console.Write("> ");
        string choice = Console.ReadLine();
        return choice;
    }
    public int DisplayAnimalMenu()
    {
        Console.WriteLine("Which animal would you like to add to your farm?");
        Console.WriteLine("1. Pig");
        Console.WriteLine("2. Cow");
        Console.WriteLine("3. Goat");
        Console.WriteLine("4. Chicken");
        Console.WriteLine("5. Alpaca");
        int choice = int.Parse(MenuChoice());
        return choice;
    }
    public int DisplayAnimalNames(Animal animal, List<string> names)
    {
        Console.WriteLine($"Which {animal} would you like to pick?");
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        int choice = int.Parse(MenuChoice());
        return choice;
    }
}