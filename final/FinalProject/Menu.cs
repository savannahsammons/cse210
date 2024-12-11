
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
        Console.WriteLine("4. Quit");
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
        Console.WriteLine("6. Quit");
        int choice = int.Parse(MenuChoice());
        return choice;
    }
}