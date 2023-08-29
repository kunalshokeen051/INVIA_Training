using System;
using System.Reflection;

public class Browse
{
   public void Details()
    {
        Assembly ptr = Assembly.LoadFrom(@"\Desktop\MyApp.dll");
      Type[] t =  ptr.GetTypes();
        foreach (var i in t)
        {
            Console.WriteLine(i);
        }
    }
    public static void Main(string[] args)
    {
        Browse obj = new Browse();
        obj.Details();
    }
}

