using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();
        List<Animal> animals = new List<Animal>();

        string playerName = menu1.DisplayFirstMenu();
        Console.WriteLine($"Hello {playerName}!");
        Farm playersFarm = new Farm();
        Store walmart = new Store();

        while(true)
        {
            int mainMenuChoice = menu1.DisplayMainMenu();
            if (mainMenuChoice == 1)
            {
                int animalChoice = menu1.DisplayAnimalMenu();
                if (animalChoice == 1)
                {
                    List<string> pigNames = walmart.GetPigNames();
                    string nameChoice = menu1.DisplayAnimalNames("pig", pigNames);
                    Pig pig1 = new Pig("pig", nameChoice, "oink");
                    playersFarm.AddAnimals(pig1);
                    walmart.RemoveName("pig", nameChoice);
                }
                if (animalChoice == 2)
                {
                    List<string> cowNames = walmart.GetCowNames();
                    string nameChoice = menu1.DisplayAnimalNames("cow", cowNames);
                    Cow cow1 = new Cow("cow", nameChoice, "moo");
                    playersFarm.AddAnimals(cow1);
                    walmart.RemoveName("cow", nameChoice);
                }
                if (animalChoice == 3)
                {
                    List<string> goatNames = walmart.GetGoatNames();
                    string nameChoice = menu1.DisplayAnimalNames("goat", goatNames);
                    Goat goat1 = new Goat("goat", nameChoice, "baa");
                    playersFarm.AddAnimals(goat1);
                    walmart.RemoveName("goat", nameChoice);
                }
                if (animalChoice == 4)
                {
                    List<string> chickenNames = walmart.GetChickenNames();
                    string nameChoice = menu1.DisplayAnimalNames("chicken", chickenNames);
                    Chicken chicken1 = new Chicken("chicken", nameChoice, "bock");
                    playersFarm.AddAnimals(chicken1);
                    walmart.RemoveName("chicken", nameChoice);
                }
                if (animalChoice == 5)
                {
                    List<string> alpacaNames = walmart.GetAlpacaNames();
                    string nameChoice = menu1.DisplayAnimalNames("alpaca", alpacaNames);
                    Alpaca alpaca1 = new Alpaca("alpaca", nameChoice, "*spits");
                    playersFarm.AddAnimals(alpaca1);
                    walmart.RemoveName("alpaca", nameChoice);
                }
            }
            if (mainMenuChoice == 2)
            {
                playersFarm.DisplayAnimals();
            }
            if (mainMenuChoice == 3)
            {
                break;
            }
        }
    }
}