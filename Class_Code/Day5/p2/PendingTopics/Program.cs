class EmployeeDetails
{
    public dynamic Info() {
      Console.WriteLine("Corporate Training");
      dynamic age;
      age = 12;
      
      return age;
     }

    public static void Main()
    {
        EmployeeDetails empObj = new EmployeeDetails();
    Console.WriteLine(empObj.Info());
    }
}
