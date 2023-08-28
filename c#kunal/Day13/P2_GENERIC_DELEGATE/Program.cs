delegate void MyDelegate();
class MyWork
{
   public void Display()
    {
        Console.WriteLine("Display function");
    }
    public static void Main()
    {
        MyWork myWork = new();
        MyDelegate myDelegate = new(myWork.Display);

        // myWork is a abstract pointer / Function Pointer

       // myDelegate(); work similiar to mydelegate.Invoke(); 
       // But is not a good programming practice use Invoke

        myDelegate.Invoke();
    }
}

// ***** This is completely unprofessional Program  *****