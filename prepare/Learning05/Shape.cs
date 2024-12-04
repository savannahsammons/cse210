
using System.Drawing;
using System.Reflection.Metadata;

class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        string clr = _color;
        return clr;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 2.8889;
    }
}