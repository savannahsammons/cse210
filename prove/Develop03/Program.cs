using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        // scripture.DisplayScripture();
        bool quitProgram = true;

        while(quitProgram == true)
        {
            Console.Clear();

            scripture.DisplayScripture();

            string answer = Console.ReadLine();

            for (int i=0;i<3;i++)
            {
                scripture.ChangeWord();
            }

            if (answer == "quit" || scripture.IsCompletelyRendered() == true)
            {
                quitProgram = false;
            }
        }
    }
}