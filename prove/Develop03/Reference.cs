
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference()
    {
        // idk
    }
    public void Display()
    {
        Console.Write($"{_book} {_chapter}:{_verse}");
    }
}