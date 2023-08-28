using System;
using System.Collections.Generic;
using Models;

namespace Functionality
{
    public interface IPersonDetails
    {
        List<Person> AddPerson();
        List<Person> DisplayPerson();
    }
}
