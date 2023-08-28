//Why Multi-threading

using System.Threading;

public class MyTask
{
    public void Task1()  //Long running Process
    {
        Thread.Sleep(4000);
        Console.WriteLine("Performing Task-1");
    }

    public void Task2()  //Light Weight Process
    {

        Console.WriteLine("Performing Task-2");
    }

    public static void Main(string[] args)   // O.S is providing 1 thread to run the application(1 thread = 2 Function)
    {
        MyTask task = new MyTask();
        task.Task1();
        task.Task2();
    }
}
