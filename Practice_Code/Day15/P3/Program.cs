public class MyClass
{
    int[] sum1 = { 2, 5, 3, 4, 5, 6, 7, 8, 9 };
    int[] sum2 = { 1, 2, 3, 4, 5 };
    int[] sum3 = {4, 5};
   public int Sum(params int[] x)
    {
           int total = 0;
        if (x.Length != 0)
        {
            foreach (int i in x)
            {
                total += i;
                return total;
            }

        }
        return 0;
    }
    public static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        Console.WriteLine("Enter the numbers");
       Console.WriteLine("With 9 arguments: {0}",myClass.Sum(myClass.sum1));
       Console.WriteLine("With 5 arguments: {0}",myClass.Sum(myClass.sum2));
       Console.WriteLine("With 2 arguments: {0}",myClass.Sum(myClass.sum3));
        
    }
}