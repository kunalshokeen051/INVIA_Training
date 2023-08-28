using System;


public delegate void Print(String value);

public class MyClass
{
	public void DownloadFile(bool status, Action onComplete)
{
	if(status == true)
	   onComplete();
}

public void HandleDownloadComplete()
{
	Console.WriteLine("Download Complete");
}

public static void Main()
{
	MyClass obj  = new();
	obj.DownloadFile(true, obj.HandleDownloadComplete);
}
}