using System;
using System.ComponentModel;


class Program
{
    static int AddNumbers(int n1, int n2)
    {
        int total = n1+n2;
        // int total2 = n1*n2;
        return total;
    }
    static void Main(string[] args)
    {
        int x = 10;
        int y = x++;
        Console.WriteLine($"{y}, {x}");
        
        int z = ++y;
        Console.WriteLine($"{z}, {y}");

        // int total = AddNumbers(20, 30);
        // Console.WriteLine(total);

        // for(int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int age = -1;

        // while(age < 0 || age > 120)
        // {
        //     Console.WriteLine("Please enter your age (0-124): ");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is {age}");
        // }

        // int age1;
        // do
        // {
        //     Console.WriteLine("Please enter your age (0-124): ");
        //     age1 = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is {age}");
        // } while(age1 < 0 || age1 > 120);

        // List <string> myColors = new List<string>();

        // myColors.Add("Red");
        // myColors.Add("Green");
        // myColors.Add("Blue");

        // foreach(string color in myColors)
        // {
        //     Console.WriteLine(color);
        // }
    }
}