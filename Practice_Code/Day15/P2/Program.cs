public class MyClass
{
    int a = 12; int b = 13;

    public void Dec(ref int x)
    {
        --x;
    }
    public void Dec(int x)
    {
        --x;
    }

    public static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        Console.WriteLine("Initial value of a is {0}", obj.a);
        Console.WriteLine("Initial value of b is {0}", obj.b);
        Console.WriteLine();

        obj.Dec(obj.a);
        obj.Dec(ref obj.b);

        Console.WriteLine("Values after opertaion performed");

        Console.WriteLine();
        Console.WriteLine("Initial value of a is {0}", obj.a);
        Console.WriteLine("Initial value of b is {0}", obj.b);
       

    }
}