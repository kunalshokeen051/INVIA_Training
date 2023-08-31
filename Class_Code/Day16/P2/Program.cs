
using System.Runtime.InteropServices;

namespace ExceptionHandlingDemo
{

	public class OddNumberException : Exception
	{
			   public override string Message
		{
			get
			{
				return "Age can't be Negative";
			}
		}

		public override string HelpLink
		{
			get
			{
				return "Get More Information from here: https://www.google.com/help";
			}
		}
	}
	
	public class MyClass
	{
		public static void Main()
		{
		OddNumberException handler = new();
			Console.WriteLine("Enter a number");
			try
			{
				int a = Convert.ToInt32(Console.ReadLine());
				if(a < 0)
				{
					throw new OddNumberException();
				}
			}
			catch(OddNumberException one)
			{
				Console.WriteLine(one.Message);
				Console.WriteLine(one.HelpLink);
			}
			finally
			{
				DateTime now = DateTime.Now;
				Console.WriteLine(now.ToString("f", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
			}
			
		}
	}
}