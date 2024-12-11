using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainMenu = new Menu();
        List<Animal> animals = new List<Animal>();

        while(true)
        {
            int animalChoice = mainMenu.DisplayMainMenu();
            if (animalChoice == 1)
            {
                Pig piggy = new Pig("Piggy", "oink");
                animals.Add(piggy);
                Console.WriteLine("Here is your new Pig, Piggy!");
            }
            if (animalChoice == 2)
            {
                Cow bessy = new Cow("Bessy", "moo");
                animals.Add(bessy);
                Console.WriteLine("Here is your new Cow, Bessy!");
            }
            if (animalChoice == 4)
            {
                break;
            }
        }
    }
}