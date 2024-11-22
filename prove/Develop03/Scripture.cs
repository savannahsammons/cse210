
using System.Globalization;

class Scripture
{
    private Reference _reference = new Reference("Alma","32","21");
    private Word word = new Word();
    private List<string> listOfWords = new List<string>();

    public List<string> ScriptureToList()
    {
        string alma32 = " And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";
        string[] splitter = alma32.Split(' ');
        foreach (string stringInArray in splitter)
        {
            listOfWords.Add(stringInArray);
        }
        return listOfWords;
    }
    public int SelectRandomWord()
    {
        Random rnd = new Random();
        int num = rnd.Next(0, listOfWords.Count());
        string wrd = listOfWords[num];
        while (word.IsHidden(wrd) == true)
        {
            num = rnd.Next(0, listOfWords.Count());
            wrd = listOfWords[num];
        }
        return num;
    }
    public bool IsCompletelyRendered()
    {
        foreach (string w in listOfWords)
        {
            if (w[0] != '_')
            {
                return false;
            }
            else
            {
                continue;
            }
        }
        return true;
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
    public List<string> ChangeWord()
    {
        int index = SelectRandomWord();
        listOfWords[index] = HideWord(listOfWords[index]);
        return listOfWords;
    }
    public string ListToString(List<string> listOfWords)
    {
        string alma32 = string.Join(" ", listOfWords);
        return alma32;
    }
    public void DisplayScripture()
    {
        _reference.Display();
        string alma32 = ListToString(listOfWords);
        Console.WriteLine(alma32);
    }
}