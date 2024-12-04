
class Circle : Shape
{
    private int _rad;
    public Circle(string color, int rad) : base(color)
    {
        _rad = rad;
    }

    public override double GetArea()
    {
        return _rad * 2 * 3.14159;
    }
}