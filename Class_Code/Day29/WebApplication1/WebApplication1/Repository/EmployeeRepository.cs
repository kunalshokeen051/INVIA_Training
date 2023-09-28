using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        int IEmployeeRepository.CreateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        int IEmployeeRepository.DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Employee> IEmployeeRepository.GetEmployees()
        {
            throw new NotImplementedException();
        }

        Employee IEmployeeRepository.SearchEmployees(int id)
        {
            throw new NotImplementedException();
        }

        int IEmployeeRepository.UpdateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}