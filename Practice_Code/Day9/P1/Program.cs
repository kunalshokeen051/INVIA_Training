internal class Day9
{ 
    public void Display<T>(T data)
    {
        Console.WriteLine(data);
    }

    public static void Main()
    {
        Day9 obj = new();
        obj.Display<int>(5);
        obj.Display<string>("data");
        obj.Display<Double>(5.452);
    }
}


// public class GFG {

// 	// Generics method
// 	public void Display<TypeOfValue>(string msg, TypeOfValue value)
// 	{
// 		Console.WriteLine("{0}:{1}", msg, value);
// 	}
// }

// // Driver class
// public class Example {

// 	// Main Method
// 	public static int Main()
// 	{

// 		// creating object of class GFG
// 		GFG p = new GFG();

// 		// calling Generics method
// 		p.Display<int>("Integer", 122);
// 		p.Display<char>("Character", 'H');
// 		p.Display<double>("Decimal", 255.67);
// 		return 0;
// 	}
// }
