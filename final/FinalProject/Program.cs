using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();
        List<Animal> animals = new List<Animal>();

        while(true)
        {
            int mainMenuChoice = menu1.DisplayMainMenu();
            if (mainMenuChoice == 1)
            {
                int animalChoice = menu1.DisplayAnimalMenu();
                if (animalChoice == 1)
                {
                    // Pig pig1 = new Pig();
                    // int nameChoice = menu1.DisplayAnimalNames();
                }
                if (animalChoice == 2)
                {
                    
                }
                if (animalChoice == 3)
                {
                    
                }
                if (animalChoice == 4)
                {
                    
                }
                if (animalChoice == 5)
                {
                    
                }
            }
            if (mainMenuChoice == 2)
            {
            }
            if (mainMenuChoice == 3)
            {
                break;
            }
        }
    }
}