using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();
        List<Animal> animals = new List<Animal>();

        string playerName = menu1.DisplayFirstMenu();
        Farm playersFarm = new Farm();

        while(true)
        {
            int mainMenuChoice = menu1.DisplayMainMenu();
            if (mainMenuChoice == 1)
            {
                int animalChoice = menu1.DisplayAnimalMenu();
                if (animalChoice == 1)
                {
                    Pig pig1 = new Pig("pig", " ", "oink"); //placeholder stuff
                    int nameChoice = menu1.DisplayAnimalNames(pig1, ["hi"]); //placeholder stuff
                    playersFarm.AddAnimals(pig1);
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
                Farm myFarm = new Farm();
                myFarm.DisplayAnimals();
            }
            if (mainMenuChoice == 3)
            {
                break;
            }
        }
    }
}