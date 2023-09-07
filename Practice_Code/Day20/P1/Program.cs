// Passing Interface as a Constructor Parameter
public interface Iplay
{
	string Play();
}

class football: Iplay
{
	public string Play()
	{
		return "Football";
	}
}

class Hockey: Iplay
{
	public string Play()
	{
		return "Hockey";
	}
}


public class BAL
{
	Iplay temp;
	public BAL(Iplay temp)
	{
		this.temp = temp;
	}
	
	public Iplay Result()
	{
		return temp;
	}
}


public class customer
{
	public static void Main()
	{
		BAL obj = new(new football());
		BAL obj1 = new(new Hockey());
		Console.WriteLine(obj.Result());
		Console.WriteLine(obj1.Result());
	}
}