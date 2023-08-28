class Father
{
    public Father() {
        Console.WriteLine("This is Father Class");
     }
    public Father(string Newspaper)
    {
        Console.WriteLine(Newspaper + "Father");
    }
}


class son : Father
{
    public son() { 
        Console.WriteLine("This is Son Class");
    }
    public son(string Newspaper):base(Newspaper){ 
        Console.WriteLine(Newspaper + "son");
    }

    public static void Main()
    {
        son obj = new son("The Indian Express");
    }
}