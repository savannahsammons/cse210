using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your number grade? ");
        string number_grade = Console.ReadLine();

        int grade = int.Parse(number_grade);
        string letter = " ";
        if (grade >= 90) {
            letter = "A";
        }
        else if (grade >= 80) {
            letter = "B";
        }
        else if (grade >= 70) {
            letter = "C";
        }
        else if (grade >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (grade >= 70) {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else {
            Console.WriteLine("Looks you didn't pass... better luck next time!");
        }
    }
}