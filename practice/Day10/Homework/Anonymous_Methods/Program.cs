using System.Collections.Generic;
using System;

public delegate void MyDelegate(string name);


internal class SampleClass
{
	public static void Main()
	{
		 // An anonymous method with one parameter
		MyDelegate obj = delegate( string name)
		{
			Console.WriteLine("My name is {0}",name);
		};
		obj("Kunal Shokeen");
	}
}


