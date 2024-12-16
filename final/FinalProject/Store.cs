
class Store
{
    private List<string> pigNames = ["Miss Piggy", "Porkchop", "Chubby", "Pumbaa", "Buttons"];
    private List<string> goatNames = ["Billy", "Buttercup", "Ramsey", "Lambchop", "Bo Peep"];
    private List<string> chickenNames = ["Clucky", "Hen Solo", "Nugget", "Chicken Little", "Albert Eggstein"];
    private List<string> alpacaNames = ["Peanut", "Butter", "Jam", "Cuzko", "Pacha"];
    private List<string> cowNames = ["Daisy", "Bessie", "Angus", "Farnando", "Betsy"];

    public List<string> GetPigNames()
    {
        return pigNames;
    }
    public List<string> GetGoatNames()
    {
        return goatNames;
    }
    public List<string> GetCowNames()
    {
        return cowNames;
    }
    public List<string> GetChickenNames()
    {
        return chickenNames;
    }
    public List<string> GetAlpacaNames()
    {
        return alpacaNames;
    }
    public void RemoveName (string animal, string animalName)
    {
        if (animal == "pig")
        {
            foreach (string name in pigNames)
            {
                if (name == animalName)
                {
                    pigNames.Remove(name);
                }
            }
        }
        if (animal == "cow")
        {
            foreach (string name in cowNames)
            {
                if (name == animalName)
                {
                    cowNames.Remove(name);
                }
            }
        }
        if (animal == "goat")
        {
            foreach (string name in goatNames)
            {
                if (name == animalName)
                {
                    goatNames.Remove(name);
                }
            }
        }
        if (animal == "chicken")
        {
            foreach (string name in chickenNames)
            {
                if (name == animalName)
                {
                    chickenNames.Remove(name);
                }
            }
        }
        if (animal == "alpaca")
        {
            foreach (string name in alpacaNames)
            {
                if (name == animalName)
                {
                    alpacaNames.Remove(name);
                }
            }
        }
    }
}