
using System;

public class MyClass
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Please enter radious for circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circumference = CalculateCircle(radius, out double area);
            Console.WriteLine($"Circle's circumference is {circumference}");
            Console.WriteLine($"Circle's Area is {area}");
            Console.ReadKey();
        }

        public static double CalculateCircle(double radius, out double area)
        {
            area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }