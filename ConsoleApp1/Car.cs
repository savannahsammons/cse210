class Car
{
    private Tire tires;

    public Car(){ tires = new Tire(205, 16, 55);}

    public void Dispaly()
    {
        tires.Display();
        Console.WriteLine("Car is alive.");
    }
}