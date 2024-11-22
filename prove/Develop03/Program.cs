using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture scripture = new Scripture();
        bool quitProgram = false;
        string alma32 = "And now as I said concerning faith— faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";
        List<string> listWords = scripture.ScriptureToList(alma32);
        scripture.DisplayScripture(listWords);
        string ans = Console.ReadLine();
        if (ans == "quit")
        {
            quitProgram = true;
        }

        while(quitProgram == false)
        {
            Console.Clear();

            List<string> newList = scripture.ChangeWords(listWords);

            scripture.DisplayScripture(newList);

            string answer = Console.ReadLine();

            if (answer == "quit" || scripture.IsCompletelyRendered(newList) == true)
            {
                quitProgram = true;
            }

            listWords = newList;
        }
    }
}