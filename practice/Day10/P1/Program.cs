internal class HCL<T>
{
    private T temp;
    public HCL(T value)
    {
        this.temp = value;
        this.Print();
    }
    public void Print()
    {
        Console.WriteLine(temp);
    }
}
    internal class Employee
    {
        public static void Main()
        {
            HCL<int> obj = new(12);
            HCL<string> obj1 = new("Visitor");
        }
    }
