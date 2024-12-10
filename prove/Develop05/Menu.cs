
class Menu
{
    int _menuChoice;

    // public Menu(int menuChoice)
    // {
    //     _menuChoice = menuChoice;
    // }
    public void DisplayMainMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public int SetAndGetMenuChoice()
    {
        _menuChoice = int.Parse(Console.ReadLine());
        return _menuChoice;
    }

    public void TypeOfGoalMenu()
    {
        Console.WriteLine("The Types of Goals Are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
    }
}