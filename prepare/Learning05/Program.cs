using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        Square square1 = new Square("blue", 5);
        Rectangle rect1 = new Rectangle("red", 4, 5);

        string color = square1.GetColor();
        double area = square1.GetArea();
        Console.WriteLine(color);
        Console.WriteLine(area);

        string colorRect = rect1.GetColor();
        double areaRect = rect1.GetArea();
        Console.WriteLine(colorRect);
        Console.WriteLine(areaRect);
    }
}