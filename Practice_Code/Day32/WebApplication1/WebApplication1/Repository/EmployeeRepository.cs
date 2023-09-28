using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeManagmentContext db = new EmployeeManagmentContext();

        int IEmployeeRepository.CreateEmployee(Employee emp)
        {
                db.employees.Add(emp);           // it will add new record in local memory
                return db.SaveChanges();        // will commit to database          
        }

        int IEmployeeRepository.DeleteEmployee(int id)
        {
            var employee = db.employees.Where(x => x.Id == id).FirstOrDefault();
            if(employee != null)
            {
            db.employees.Remove(employee);
            db.SaveChanges();
            return 1;
            }
            return 0;
        }

        IEnumerable<Employee> IEmployeeRepository.GetEmployees()
        {
         return  db.employees.ToList();
        }

        Employee IEmployeeRepository.SearchEmployees(int id)
        {
            var employee = db.employees.Where(x => x.Id == id).FirstOrDefault();
            return employee;
        }

        int IEmployeeRepository.UpdateEmployee(int Id,string Name)
        {
            var employee = db.employees.Where(x => x.Id == Id).FirstOrDefault();
            if (employee != null)
            {
                employee.Name = Name;
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
    }
}