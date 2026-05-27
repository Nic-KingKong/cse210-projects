class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        Angle angle = new Angle();
        angle.SetRadians(10);
        Console.WriteLine($"Angle: {angle.GetRadians()} radians");

        Angle angle2 = new Angle(100.234);
        Console.WriteLine(angle2.GetRadians());
    }
}