
using System.Globalization;

class Scripture
{
    private Reference _reference = new Reference();
    private Word word = new Word();
    private List<string> listOfWords = new List<string>();

    // public Scripture()
    // {
    //     // void
    // }
    public override void ToString()
    {
        // string
    }
    public void SelectRandomWord()
    {
        Random rnd = new Random();
        for(int i = 0;i<=3;i++)
        {
            int num = rnd.Next(0, listOfWords.Count());
            if (word.IsHidden(listOfWords[num]) = true)
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
        // void
    }
}