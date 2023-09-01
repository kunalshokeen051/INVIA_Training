/* ----- Exception Handling --------  */
using System.Data;

public class MyApp
{
	public void Connect()
	{
		string[] i = new string[3];
		try
		{
			i[0] = "Kunal";
			i[1] = "Pankaj";
			i[2] = "Nilanshu";
			i[3] = "Nilanshu garg";
			Console.WriteLine(i[3]);
		}
		catch (DivideByZeroException ab)
		{
			Console.WriteLine("error message\t"+ab.Message); //Show the error message
		}
		catch (IndexOutOfRangeException a)
		{
			Console.WriteLine("error message\t"+a.Message); //Show the error message
		}
		catch (Exception e)
		{
			Console.WriteLine("error message\t"+e.Message); //Show the error message
		}
	}

	public static void Main()
	{
		MyApp obj = new();
		obj.Connect();
	}
}


public interface ICounter<T>
{
}
Y




public a