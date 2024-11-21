
using System.Globalization;

class Scripture
{
    private Reference _reference = new Reference("Alma","32","21");
    private Word word = new Word();
    private List<string> listOfWords = new List<string>();

    public List<string> ScriptureToList()
    {
        string alma32 = " And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";
        for (int i = 0;i < alma32.Count();i++)
        {
            alma32.Split(" ");
            listOfWords.Add(alma32);
        }
        return listOfWords;
    }
    public void SelectRandomWord()
    {
        Random rnd = new Random();
        for(int i = 0;i<=3;i++)
        {
            string wrds = listOfWords[i];
            int num = rnd.Next(0, listOfWords.Count());
            if (word.IsHidden(wrds) == true)
            {
                // cant choose word
            }
        }
    }
    public void IsCompletelyRendered()
    {
        // bool
    }
    public string HideWord(string word)
    {
        string underscores = "";
        for (int i=0; i < word.Count();i++)
        {
            underscores += "_";
        }
        return underscores;
    }
    public void DisplayScripture()
    {
        string alma32 = " And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";
        _reference.Display();
        Console.WriteLine(alma32);
    }
}