class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello World");

        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetArea());

        myCircle._radius = 20;
        Console.WriteLine(myCircle._radius);
        Console.WriteLine(myCircle.GetArea());

        Circle myCircle2 = new Circle();
        myCircle2._radius = 30;
        Console.WriteLine(myCircle2.GetArea());

        Cylinder myCylinder = new Cylinder();
        myCylinder._circle = myCircle;
        myCylinder._height=10;


    }
}