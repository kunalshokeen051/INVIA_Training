public class MyClass
{

	public async Task Method1()
	{
		int Hours;
		int Minutes;
		int Second;
		
		await Task.Run(
			() => 
			{
				for (Hours =00; Hours < 24; Hours++)
				{
					for (int Minutes = 00; Minutes < 60 ; Minutes++)
				{
					for (Second = 00; Second < 60 ; Second++)
				{
					Console.WriteLine($"{Hours}:{Minutes}:{Second}");
					Task.Delay(1000).Wait();
				}
				}
				}
			}
		);
}
	public void Method2()
	{
		 Task.Run(() =>
			{
				for (int i = 0; i < 20; i++)
				{
					Console.WriteLine("I am Method 2");
					Task.Delay(1000).Wait();
				}
			});
	}
	public static void Main()
	{
		MyClass obj = new();
		// obj.Method2();
		obj.Method1();
		Console.ReadKey();
	}
}