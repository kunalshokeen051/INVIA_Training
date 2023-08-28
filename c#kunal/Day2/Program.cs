using System;
using System.Collections.Generic;

class person
{
    public string Name;
    public  string qual;
   
}
class personDetails
{
    public   List<person> AddPerson()
    {
        List<person> objList=new List<person>();
        objList.Add(new person{
            Name="sandeep",
            qual="BPTECH"
        });

        objList.Add(new person{
            Name="sandeep tyagi",
            qual="BPTECH"
        });

        objList.Add(new person{
            Name="sandeep pandey",
            qual="BPTECH"
        });

        return objList;
    }
}
class HR
{
    public static void Main()
    {
         personDetails obj=new personDetails();
          var t=obj.AddPerson();
          foreach(var temp in t)
          {
              Console.WriteLine(temp.Name+" "+temp.qual);
          }
        
    }
}