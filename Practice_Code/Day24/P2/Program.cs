
public class MyClass {
  [ThreadStatic]
  public static int myVariable;
	public  int Myvar;
	
	 [Obsolete("Deprecated Method",false)]  
	public void MyMethod()
	{
		Console.WriteLine("This is my Method");
	}
}

class class1
{
	public static void Main()
	{
		MyClass.myVariable = 1;
		MyClass.myVariable += 1;
		
		MyClass obj = new();
		obj.Myvar = 1;
		obj.Myvar = +1;
		
		

		Console.WriteLine(MyClass.myVariable);
		Console.WriteLine(obj.Myvar);

		obj.MyMethod();
	}
}