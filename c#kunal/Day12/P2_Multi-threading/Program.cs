//How to handle the concurrency problem in multiple threading

using System.Threading;

public class Office
{ 
   public void Print()
    {
        lock (this)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Printing at:{0}", i);
            }
        }
    }

    public static void Main(string[] args)
    {
       Office obj = new Office();
        Thread[] t = new Thread[3];
        for(int i=0;i<3; i++)
        {
            t[i] = new Thread(new ThreadStart(obj.Print));
        } 
        for(int i=0;i<3; i++)
        {
            t[i].Start();
        }
    }
}

