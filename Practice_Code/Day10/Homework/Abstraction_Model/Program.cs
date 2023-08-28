public delegate void Delegate1(int num1, int num2);
public class Sample
{
    public void Sum(int a, int b)
    {
        Console.WriteLine("Sum of {0} and {1} is {2} ", a, b, a + b);
    }
    public void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction of {0} and {1} is {2} ", a, b, a - b);
    }
    public void Mul(int a, int b)
    {
        Console.WriteLine("Product of {0} and {1} is  {2}", a, b, a * b);
    }
    public void Div(int a, int b)
    {
        Console.WriteLine("Remainder of {0} divided by {1} is {2} ", a, b, a%b);
    }
}

public class Abstraction_Model
{
    public static void Main()
    {
        Sample obj = new();
        Delegate1 obj1 = new(obj.Sum);
        obj1 += obj.Sub;
        obj1 += obj.Mul;
        obj1 += obj.Div;
        obj1(15,26);
    }
}