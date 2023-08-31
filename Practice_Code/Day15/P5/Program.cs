using System.Runtime.CompilerServices;

public class MyClass
{
    struct Coordinate
    {
        public double x;
        public double y;
    }
    public static void Main(string[] args)
    {
        Random rnd=new();
        Coordinate point = new Coordinate();
        double x = (rnd.NextDouble())*100;
        double y = (rnd.NextDouble())*100;
        point.x = x;
        point.y = y;
        Console.WriteLine("X coordinate {0}",point.x);
        Console.WriteLine("Y-coordinate {0}",point.y);
    }

}