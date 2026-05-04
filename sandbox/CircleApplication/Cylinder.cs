
class Cylinder
{
    public Circle _circle;

    public double _height;

    public double GetCylinderHeight()
    {
        return _circle.GetArea() * _height;
    }
}