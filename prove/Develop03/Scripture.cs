
using System.Globalization;
using System.Runtime.ExceptionServices;

class Scripture
{
    private Reference _reference = new Reference("Alma","32","21");
    private Word word = new Word();
    private List<string> listOfWords = new List<string>();

    public List<string> ScriptureToList(string alma32)
    {
        string[] splitter = alma32.Split(' ');
        foreach (string stringInArray in splitter)
        {
            listOfWords.Add(stringInArray);
        }
        return listOfWords;
    }
    public int SelectRandomWord(List<string> listWords)
    {
        Random rnd = new Random();
        int num = rnd.Next(0, listWords.Count());
        string wrd = listWords[num];
        while (word.IsHidden(wrd) == true)
        {
            num = rnd.Next(0, listWords.Count());
            wrd = listWords[num];
        }
        return num;
    }
    public bool IsCompletelyRendered(List<string> newL)
    {
        foreach (string w in newL)
        {
            if (word.IsHidden(w) == false)
            {
                return false;
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
    public List<string> ChangeWords(List<string> listWords)
    {
        for(int i=0;i<3;i++)
        {
            int index = SelectRandomWord(listWords);
            listWords[index] = HideWord(listWords[index]);
        }
        return listWords;
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
        Console.WriteLine($" {alma32}");
    }
}