using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu();

        while(true)
        {
            int animalChoice = mainMenu.DisplayMainMenu();
            if (animalChoice == 1)
            {
                Pig piggy = new Pig("Piggy", "oink");
                Console.WriteLine("Here is your new Pig, Piggy!");
            }
            if (animalChoice == 2)
            {
                Cow bessy = new Cow("Bessy", "moo");
                Console.WriteLine("Here is your new Cow, Bessy!");
            }
            if (animalChoice == 4)
            {
                break;
            }
        }
    }
}