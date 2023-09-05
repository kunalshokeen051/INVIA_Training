// Partial Class in C#

namespace MyNamespace
{
	public partial class Employee
	{
		public int Id;
		public string Name;

		public void Add(int Id, string Name)
		{
			this.Id = Id;
			this.Name = Name;
			Console.WriteLine("Employee details added");
			Display();
		}
	}

	public partial class Employee
	{
		public void Display()
		{
			Console.WriteLine($"Id is: {Id} and Name is {Name.ToUpper()}");
		}
	}

	public partial class Employee
	{
		public void TakeInput()
		{
			Console.WriteLine("Enter Id of employee");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter name of employee");
			string b = Console.ReadLine();
			Add(a, b);
		}
	}

	public class MyClass
	{
		public static void Main()
		{
			Employee obj = new();
			obj.TakeInput();
		}
	}
}
