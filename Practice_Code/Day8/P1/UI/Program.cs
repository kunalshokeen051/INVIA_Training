internal class Candidate
{
    private int Exp;
    private string Skills;
    private string Qual;
    public int Experience
    {
        get
        {
            return Exp;
        }
        set
        {
            Exp = value;
            if (Exp < 3)
            {
                Console.WriteLine("Criteria Failed!");
            }
        }
    }
    public string SkillSet
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
          set
        {
            Qual = value;
        }
    }
}
class HR
{

}
class Organisation
{
    public static void Main()
    {
        Candidate obj = new Candidate();
        obj.Experience = 2;
        obj.Qualification = "MCA";
        obj.SkillSet = "C#";
    }
}