using System;
using System.Threading.Tasks; 
class MyService
{ 
	public void Download()
	{
		 Thread.Sleep(6000);
		Console.WriteLine("Task is Completed");
	}
	public void Training()
	{
		Console.WriteLine("This is Local Task");
	}
	public async Task Tarun() 
	{ 
		await Task.Run(Download);
		Console.WriteLine("I am free");
	   
	}
	public static void Main() 
	{
		 MyService obj = new MyService();
		 obj.Tarun();
		 
		 obj.Training(); 
		 Console.ReadKey();
	}

}
