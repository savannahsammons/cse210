
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
            for (int i = pigNames.Count - 1; i >= 0; i--)
            {
                if (pigNames[i] == animalName)
                {
                    pigNames.RemoveAt(i);
                }
            }

        }
        if (animal == "cow")
        {
            for (int i = cowNames.Count - 1; i >= 0; i--)
            {
                if (cowNames[i] == animalName)
                {
                    cowNames.RemoveAt(i);
                }
            }
        }
        if (animal == "goat")
        {
            for (int i = goatNames.Count - 1; i >= 0; i--)
            {
                if (goatNames[i] == animalName)
                {
                    goatNames.RemoveAt(i);
                }
            }
        }
        if (animal == "chicken")
        {
            for (int i = chickenNames.Count - 1; i >= 0; i--)
            {
                if (chickenNames[i] == animalName)
                {
                    chickenNames.RemoveAt(i);
                }
            }
        }
        if (animal == "alpaca")
        {
            for (int i = alpacaNames.Count - 1; i >= 0; i--)
            {
                if (alpacaNames[i] == animalName)
                {
                    alpacaNames.RemoveAt(i);
                }
            }
        }
    }
}