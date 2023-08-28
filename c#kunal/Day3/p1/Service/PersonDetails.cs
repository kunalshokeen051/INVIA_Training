using System;
using System.Collections.Generic;
using Day3.Models;

namespace Day3.Service;
    public class PersonDetails
    {
        List<Person> objList=new List<Person>();
        public   List<Person> AddPerson()
      {
         objList.Add(new Person{
            Name="sandeep",
            qual="BTECH"
        });

        objList.Add(new Person{
            Name="sandeep tyagi",
            qual="BTECH"
        });

        objList.Add(new Person{
            Name="sandeep pandey",
            qual="BTECH"
        });
        return objList;
      } 
      public List<Person> DisplayPerson(){
          return objList;
      }
    }
