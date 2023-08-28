using System;
using System.Collections.Generic;
using Models;

namespace Service
{
    public interface IPersonDetails
    {
        List<Person> AddPerson();
        List<Person> DisplayPerson();
    }
}
