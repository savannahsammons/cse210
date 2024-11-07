class Car
{
    private Tire tires;

    public Car()
    {
        tires = new Tire(205, 55, 16);
    }

    public void Display()
    {
        tires.Display();
        Console.WriteLine("Car is alive.");
    }
}