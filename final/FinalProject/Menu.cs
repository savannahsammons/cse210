
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

class Menu
{
    
    public int DisplayMainMenu()
    {
        Console.WriteLine("=== Welcome to the Farm Simulation! ===\n");
        Console.WriteLine("Which animal would you like to add to your farm?");
        Console.WriteLine("1. Pig");
        Console.WriteLine("1. Cow");
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
}