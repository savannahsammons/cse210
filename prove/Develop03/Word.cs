
class Word
{
    public bool IsHidden(string word)
    {
        if (word[0] == '_')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}