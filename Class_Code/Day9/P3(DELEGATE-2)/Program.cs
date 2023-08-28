using System;

class GFG
{
    public delegate void AddVal(int x, int y);

    public void SMeth(int x, int y)
    {
        Console.WriteLine("[{0} + {1}] = [{2}]", x, y, x + y);
    }
    public void SMeth1(int x, int y)
    {
        Console.WriteLine("[{0} - {1}] = [{2}]", x, y, x - y);
    }

    public static void Main(String[] args)
    {
        GFG o = new GFG();

        AddVal obj = new AddVal(o.SMeth);
        obj += o.SMeth1;
        Console.WriteLine("Enter First Number");
        int temp1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter First Number");
        int temp2 = Convert.ToInt32(Console.ReadLine());
        obj(temp1, temp2);
    }
}