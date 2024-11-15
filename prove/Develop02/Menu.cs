
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

class Menu
{
    // private string title;
    // private string description;
    private int menuItem;

    public void Display()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Display");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        menuItem = int.Parse(Console.ReadLine());
    }
}