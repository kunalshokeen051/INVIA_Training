using System;

public class Employee
{
    public void Discipline()
    {
        Console.WriteLine("Following...");
    }

    public static void Main(string[] args)
    {
       Employee obj = new Employee();
        obj.Discipline();
        Console.ReadKey();
    }
}
