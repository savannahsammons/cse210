using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Resume myResume = new Resume(name);

        myResume.Display();
    }
}