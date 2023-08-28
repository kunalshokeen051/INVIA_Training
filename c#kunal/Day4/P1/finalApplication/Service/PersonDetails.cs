using System;
using System.Collections.Generic;
using Models;
using Functionality;

namespace Service;

public class PersonDetails : IPersonDetails
{
    List<Person> objList = null;

    public PersonDetails()
    {
        objList = new List<Person>(); //Best Practice
    }

    public List<Person> AddPerson()
    {
        objList.Add(new Person { Name = "Kunal Shokeen", qual = "MCA" });

        objList.Add(new Person { Name = "Pankaj", qual = "MBA" });

        objList.Add(new Person { Name = "Rahul", qual = "B.Tech" });
        return objList;
    }

    public List<Person> DisplayPerson()
    {
        return objList;
    }
}
