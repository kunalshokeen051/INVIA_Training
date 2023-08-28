internal class Candidate
{
    private dynamic[] MyData = new dynamic[3];

    public dynamic this[int i]{

        get{
     return  MyData[i];
    }
    set{
      MyData[i] = value;
    }
}

}
class Organisation
{
    public static void Main()
    {
        Candidate kunal = new Candidate();
        kunal[0] = "MCA";
        kunal[1] = 2022;
        kunal[2] = "HR";
        Console.WriteLine(kunal[0]);
    }
}