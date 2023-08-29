
public class MyClass
{
   enum week       // Contains read-only Variable
   {
     Sunday,
     Monday,
     Tuesday,
     Wednesday,
     Thursday,
     Friday,
     Saturday,
   }
    public static void Main()
    {
        int i = 0;
        foreach (string s in Enum.GetNames(typeof(week)))
        {
               Console.WriteLine($"{++i}. {s}");
        }
        Console.ReadKey();
    }

}