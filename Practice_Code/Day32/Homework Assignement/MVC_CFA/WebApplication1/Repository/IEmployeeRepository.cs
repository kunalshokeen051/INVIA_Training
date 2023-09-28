using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IEmployeeRepository
    {
        // to get all the records
        IEnumerable<EmployeeSalaryViewModel> GetEmployees();

        // to search for a single record
        Employee SearchEmployees(int id);

        // to add new employee record
        int CreateEmployee(Employee emp);

        // to UPDATE employee record
        int UpdateEmployee(int id, string name);

        // to DELETE employee record
        int DeleteEmployee(int id);      
    }
}
