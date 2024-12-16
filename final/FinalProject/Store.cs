
class Store
{
    private bool _isTaken;
    private List<string> pigNames = ["Miss Piggy", "Porkchop", "Chubby", "Pumbaa", "Buttons"];
    private List<string> goatNames = ["Billy", "Buttercup", "Ramsey", "Lambchop", "Bo Peep"];
    private List<string> chickenNames = ["Clucky", "Hen Solo", "Nugget", "Chicken Little", "Albert Eggstein"];
    private List<string> alpacaNames = ["Peanut", "Butter", "Jam", "Cuzko", "Pacha"];
    private List<string> cowNames = ["Daisy", "Bessie", "Angus", "Farnando", "Betsy"];

    public void GetPigNames()
    {
        foreach (string name in pigNames)
        {
            Console.WriteLine(name);
        }
    }
    public void GetGoatNames()
    {
        foreach (string name in goatNames)
        {
            Console.WriteLine(name);
        }
    }
    public void GetCowNames()
    {
        foreach (string name in cowNames)
        {
            Console.WriteLine(name);
        }
    }
    public void GetChickenNames()
    {
        foreach (string name in chickenNames)
        {
            Console.WriteLine(name);
        }
    }
    public void GetAlpacaNames()
    {
        foreach (string name in alpacaNames)
        {
            Console.WriteLine(name);
        }
    }
}