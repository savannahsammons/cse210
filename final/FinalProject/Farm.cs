
class Farm
{
    List<Animal> farmAnimals = new List<Animal>();

    public void AddAnimals(Animal animal)
    {
        farmAnimals.Add(animal);
    }

    public void DisplayAnimals()
    {
        foreach (Animal animal in farmAnimals)
        {
            Console.WriteLine(animal);
        }
    }
}