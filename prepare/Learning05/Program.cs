using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        Square square1 = new Square("blue", 5);
        Rectangle rect1 = new Rectangle("red", 4, 5);
        Circle circ1 = new Circle("green", 5);

        string colorSqr = square1.GetColor();
        double areaSqr = square1.GetArea();
        Console.WriteLine(colorSqr);
        Console.WriteLine(areaSqr);

        string colorRect = rect1.GetColor();
        double areaRect = rect1.GetArea();
        Console.WriteLine(colorRect);
        Console.WriteLine(areaRect);

        string colorCirc = circ1.GetColor();
        double areaCirc = circ1.GetArea();
        Console.WriteLine(colorCirc);
        Console.WriteLine(areaCirc);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circ1);
        shapes.Add(rect1);
        shapes.Add(square1);
        foreach(Shape thing in shapes)
        {
            string color = thing.GetColor();
            double area = thing.GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);
        }
    }
}