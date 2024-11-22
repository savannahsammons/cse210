
using System.Globalization;
using System.Runtime.ExceptionServices;

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
        listOfWords = ScriptureToList();
        int num = rnd.Next(0, listOfWords.Count());
        string wrd = listOfWords[num];
        while (word.IsHidden(wrd) == false)
        {
            num = rnd.Next(0, listOfWords.Count());
            wrd = listOfWords[num];
        }
        return num;
    }
    public bool IsCompletelyRendered(List<string> newL)
    {
        foreach (string w in newL)
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
    public List<string> ChangeWords()
    {
        for(int i=0;i<3;i++)
        {
            int index = SelectRandomWord();
            listOfWords[index] = HideWord(listOfWords[index]);
        }
        return listOfWords;
    }
    public string ListToString(List<string> scriptureList)
    {
        string alma32 = string.Join(" ", scriptureList);
        return alma32;
    }
    public void DisplayScripture(List<string> newList)
    {
        _reference.Display();
        string alma32 = ListToString(newList);
        Console.WriteLine(alma32);
    }
}