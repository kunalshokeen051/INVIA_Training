class Account
{
    private Account()     // Private Constructor
    { 

    }

    public static void Main()
    {
        Account account = new Account();

        // Object can be made but not
        // outside the scope of the class
    }
}

class AccountOne:Account   
{
   // This result in an error  --> Instantiation Control
}