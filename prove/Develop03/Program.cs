using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        // scripture.DisplayScripture();
        bool quitProgram = false;

        while(quitProgram == false)
        {
            Console.Clear();

            List<string> newList = scripture.ChangeWords();

            scripture.DisplayScripture(newList);

            string answer = Console.ReadLine();

            if (answer == "quit" || scripture.IsCompletelyRendered(newList) == true)
            {
                quitProgram = true;
            }
        }
    }
}