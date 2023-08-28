
class MyWork
{

    public bool checker(string str)
    {
        return str.Equals(str.ToLower());
    }

    public static void Main()
    {
        MyWork myWork = new MyWork();
        Predicate<string> s = myWork.checker;
            Console.WriteLine("Enter Password:");
        string password = Console.ReadLine();
        if (s(password) == true)
        {
            Console.WriteLine("Correct password!");
        Console.ReadKey();
        }
        else if (s(password) == false)
        {
            Console.WriteLine("Incorrect Password!");
        Console.ReadKey();

        }
    }
}

        // myWork is a abstract pointer / Function Pointer

        // myDelegate(); work similiar to mydelegate.Invoke(); 
        // But is not a good programming practice, use Invoke