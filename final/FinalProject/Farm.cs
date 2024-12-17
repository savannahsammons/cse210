
class Farm
{
    List<Animal> farmAnimals = new List<Animal>();

    public void AddAnimals(Animal animal)
    {
        farmAnimals.Add(animal);
    }

    public void DisplayAnimals()
    {
        Console.WriteLine("");
        foreach (Animal animal in farmAnimals)
        {
            string type = animal.GetAnimalType();
            string name = animal.GetAnimalName();
            Console.WriteLine($"{name} (the {type})");
        }
    }
    public string PetAnimal(string animalName)
    {
        foreach(Animal animal in farmAnimals)
        {
            if (animal.GetAnimalName() == animalName)
            {
                return animal.GetAnimalSound();
            }
        }
        return "This animal does not exist in your farm";
    }
}