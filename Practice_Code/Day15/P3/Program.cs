using System.Globalization;

public class MyClass
{
	int[] sum1 = { 2, 5, 3, 4, 5, 6, 7, 8, 9 };
	int[] sum2 = { 1, 2, 3, 4, 5 };
	int[] sum3 = { 4, 5 };
	public void Sum(params dynamic[] x)
	{
		for(int i=0;i<x.Length;i++)
		{
			Console.WriteLine(x[i]);
		}
		// long sum = 0;
		// Console.WriteLine(a);
		// foreach (object i in x)
		// {
		// 	Console.WriteLine(i);
		// }

		// return sum;
	}
	public static void Main()
	{
		MyClass myClass = new MyClass();

		// Console.WriteLine("Enter the numbers");
		//    Console.WriteLine("With 9 arguments: {0}",myClass.Sum(myClass.sum1));
		//    Console.WriteLine("With 5 arguments: {0}",myClass.Sum(myClass.sum2));
		//    Console.WriteLine("With 2 arguments: {0}",myClass.Sum(myClass.sum3));
		 myClass.Sum("a", 5, true);
	}
}