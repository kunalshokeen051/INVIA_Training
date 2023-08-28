class Day7
{
    public void Sort<T>(T ctr)
    {
       Console.WriteLine(ctr);
    }
    public static void Main()
    {
        Day7 obj = new();
        obj.Sort<int>(204554);
        obj.Sort<string>("Kunal");
    }
}