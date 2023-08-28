delegate string MyDelegate();


class Personal
{
    public string Address()
    {
        return "gurgaon sector-39";
    }
    public double Expenses()
    {
        return 1230;
    }
}

class PersonalOne
{
    public string Address()
    {
        return "gurgaon sector-52";
    }
    public double Expenses()
    {
        return 1230;
    }
}

public class Candidate
{
    public static void Main()
    {
        Personal obj = new();
        PersonalOne obj1 = new();
        MyDelegate objDelegate = new(obj.Address);
        Console.WriteLine("Result:{0}",objDelegate());
        objDelegate += obj1.Address;
        Console.WriteLine("Result:{0}",objDelegate());
    }
}


