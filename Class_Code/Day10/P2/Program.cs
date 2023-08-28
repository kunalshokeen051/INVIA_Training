using System;

public delegate int Arithm(int a, int b);

public class ArithmeticFunctions
{

	public int Add(int a, int b)
	{
		return a+b;
	}

	public int Sub(int a, int b)
	{
		return a-b;
	}

	public int Mul(int a, int b)
	{
		return a*b;
	}

	public int Div(int a, int b)
	{
		return a/b;
	}
}

public class Class2
{
	public void DoOperation(int x, int y, Arithm del)
	{
		Console.WriteLine("Output is:{0}",del(x, y));
	}

	public static void Main()
	{
		ArithmeticFunctions obj = new();
		Class2 obj1 = new();
		obj1.DoOperation(5, 6, obj.Add);
		obj1.DoOperation(5, 6, obj.Sub);
		obj1.DoOperation(5, 6, obj.Mul);
		obj1.DoOperation(5, 6, obj.Div);
	}
}
