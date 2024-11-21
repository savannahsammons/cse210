
class Word
{
    // private string _word;
    // public string HideWord(string word)
    // {
    //     string underscores = "";
    //     for (int i=0; i < word.Count();i++)
    //     {
    //         underscores += "_";
    //     }
    //     return underscores;
    // }
    public bool IsHidden(string word)
    {
        if (word[0] == '_')
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}