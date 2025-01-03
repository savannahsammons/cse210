
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

class Menu
{
    Farm myFarm = new Farm();
    private string MenuChoice()
    {
        Console.Write("> ");
        string choice = Console.ReadLine();
        return choice;
    }
    public string DisplayFirstMenu()
    {
        Console.WriteLine("=== Welcome to the Farm Simulation! ===\n");
        Console.Write("What is your name? ");
        string playerName = Console.ReadLine();
        return playerName;
    }

    public int DisplayMainMenu()
    {
        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine("1. Buy an animal");
        Console.WriteLine("2. Show my animals");
        Console.WriteLine("3. Quit");
        Console.WriteLine("Enter a number...");
        int choice = int.Parse(MenuChoice());
        return choice;
    }
    public int DisplayAnimalMenu()
    {
        Console.WriteLine("\nWhich animal would you like to add to your farm?");
        Console.WriteLine("1. Pig");
        Console.WriteLine("2. Cow");
        Console.WriteLine("3. Goat");
        Console.WriteLine("4. Chicken");
        Console.WriteLine("5. Alpaca");
        Console.WriteLine("Enter a number...");
        int choice = int.Parse(MenuChoice());
        return choice;
    }
    public string DisplayAnimalNames(string animal, List<string> names)
    {
        Console.WriteLine($"\nWhich {animal} would you like to pick?");
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("Enter a name...");
        Console.Write("> ");
        string choice = Console.ReadLine();
        return choice;
    }
}