using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int check = 0;
        List <int> numbers = new List<int>();

        int sum = 0;
        int average = 0;
        int largest = 0;

        while (check != 0)
        {
            int newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);
            if (newNumber == 0)
            {
                check = 0;
            }

        }

        foreach (int num in numbers)
        {
            sum += num;
        }
        foreach (int num in numbers)
        {
            average = sum / numbers.Count;
        }
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}