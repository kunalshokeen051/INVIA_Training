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

class auth{
    private string userId = "kunal99";
    private int password = 123;

    public string showUser{
        get{
            return userId;
        }
        set{
           userId = value; 
        }
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
        auth authObj = new auth();
        Console.WriteLine(authObj.showUser);
        authObj.showUser ="pankaj.negi";
        Console.WriteLine(authObj.showUser);
    }
}