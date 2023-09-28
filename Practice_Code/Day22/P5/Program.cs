public class MyFunctions
{
	public string Downloading() {
		Console.WriteLine("\n--- Download Started ----");
		Console.WriteLine("\nEstimated time to Complete: 6 Seconds");
		Task.Delay(6000).Wait();
		return "\n---- Downloading Completed ----";
	 }

	public async Task<string> SurfingInternet()
	{
		MyFunctions obj = new();
		Console.WriteLine("\n--- Surfing Internet Started ----");
		var LongTask = await Task<string>.Run(obj.Downloading);
		Console.WriteLine(LongTask);
		return "\nSurfing Internet Completed!";
	}

	public string Youtube()
	{
		return "\nWatching Youtube";
	}
}

public class MyClass
{
	public static void Main()
	{
		MyFunctions obj = new();
        Console.WriteLine(obj.SurfingInternet().Result); 
		Console.WriteLine(obj.Youtube());
		Console.ReadKey();
	}
}
