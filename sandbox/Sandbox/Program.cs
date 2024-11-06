using System;
using System.ComponentModel;
using System.Formats.Asn1;


class Program
{
    // static int AddNumbers(int n1, int n2)
    // {
    //     int total = n1+n2;
    //     // int total2 = n1*n2;
    //     return total;
    // }

    class Circle
    {
        private double radius;
        // public double radius;
        // private double area;

        public Circle(double radius)
        {
            Console.WriteLine("In the constructor");
            this.radius = radius;
            // area = Math.PI * radius * radius;
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public double GetDiameter()
        {
            return radius * 2;
        }
        public double GetCircumference()
        {
            return Math.PI * 2 * radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public void Display()
        {
            Console.WriteLine($"Area is: {GetArea()}");
            Console.WriteLine($"Radius is: {GetRadius()}");
            Console.WriteLine($"Diameter is: {GetDiameter()}");
            Console.WriteLine($"Circumference is: {GetCircumference()}");
        }
    }

    static void Main(string[] args)
    {

        Console.WriteLine("Bonjour mes amis, comment ca va?");

        int x = 10;

        Circle myCircle = new Circle(x);
        Circle myCircle2 = new Circle(x+10);

        Console.WriteLine(myCircle.GetArea());
        Console.WriteLine(myCircle2.GetArea());

        Console.WriteLine(myCircle.GetCircumference());
        Console.WriteLine(myCircle.GetDiameter());
        Console.WriteLine(myCircle.GetRadius());

        myCircle.Display();
        myCircle.SetRadius(x+100);
        Console.WriteLine();
        myCircle.Display();

        // myCircle.radius = 10; // Cant do this bc it is private...


        // int x = 10;
        // int y = x++;
        // Console.WriteLine($"{y}, {x}");

        // int z = ++y;
        // Console.WriteLine($"{z}, {y}");

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