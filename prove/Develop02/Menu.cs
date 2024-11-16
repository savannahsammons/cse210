
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

class Menu
{
    private int menuItem;
    public void Display()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Write with Mystery Prompt");
        Console.WriteLine("6. Quit");
        Console.Write("What would you like to do? ");
    }
    public int ProcessMenu()
    {
        menuItem = int.Parse(Console.ReadLine());

        return menuItem;
    }
}