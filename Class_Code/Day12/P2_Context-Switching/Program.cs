//Multi-threading Praogram

using System.Threading;

public class MyTask
{ 
    public void Task1() // Run this function with seperate thread
    {
            Thread.Sleep(4000);
       for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Performing Task-1");
        }
    }

    public void Task2() //light weight task, use Main Thread
    {

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Performing Task-1");
        }
    }

    public static void Main(string[] args)
    {
        MyTask task = new MyTask();
        task.Task2();
        Thread t = new(new ThreadStart(task.Task1)); 
         t.Start();
        Console.ReadKey();
    }
}

//This is Context switching, gives an impression of multi-threading
// Because all the threads are taken from single processor
// Do Recommedation : USE TPL(TASK PARALLEL LIBRARY)
