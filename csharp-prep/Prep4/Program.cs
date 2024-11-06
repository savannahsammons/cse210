using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List <int> numbers = new List<int>();

        int sum = 0;
        float average = 0;
        int largest = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            int newNumber = int.Parse(Console.ReadLine());
            if (newNumber == 0)
            {
                break;
            }
            numbers.Add(newNumber);
        }

        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
        }
        
        if (numbers.Count > 0)
        {
            average = (float)sum / numbers.Count;
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}