using System;
// Concept Of Delegates
delegate string MyDelegate(int temp);

class Personal
{
	public string Address()
	{
		return "Noida 52";
	}

	public double Expenses()
	{
		return 1230;
	}
}

public class Candidate
{
	public static void Main()
	{
		Personal obj = new();
		MyDelegate objDelegate = (int temp) => { return "The number is:{0}",temp; };
		Console.WriteLine(objDelegate.Invoke(24)); 
 
	}
}

 // Delegate is type to wrap the function method to execute the function.