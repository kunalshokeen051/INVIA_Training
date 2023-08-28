internal class Candidate
{
    private int Exp;
    private string Qual;
    private string Skills;

    public int Experience
    {
        get
        {
            return Exp;
        }
        set
        {
            Exp = value;
        }
    }
    public string[] Skills
    {
        get
        {
            return Skills;
        }
        set
        {
               Skills = value;
        }
    }
    public string Qualification
    {
        get
        {
            return Qual;
        }
`        set
        {
            Qual = value;
        }
    }
}
class Person
{
    Candidate obj = new();

    public void AddData()
    {
        obj.Experience = 10;
        // obj.Skills = {"JAVA","C#","JAVASCRIPT","TYPESCRIPT"};
        obj.Qualification = "MCA";
        Console.WriteLine(obj.Experience);
        Console.WriteLine(obj.Qualification);
    }

}
class Organisation
{
    public static void Main()
    {
        Person obj1 = new();
        obj1.AddData();
        // foreach (var skill in obj.Skills)
        // {
        //     Console.WriteLine(skill);
        // }
    }
}