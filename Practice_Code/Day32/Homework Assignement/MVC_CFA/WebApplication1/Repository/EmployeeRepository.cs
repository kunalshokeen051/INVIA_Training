using System;
using System.Collections.Generic;
using System.Data.Entity;
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

                db.employees.Add(emp);
                db.Salaries.Add(emp.Salary); 
                return db.SaveChanges();              
        }

        int IEmployeeRepository.DeleteEmployee(int id)
        {
            var employee = db.employees.FirstOrDefault(e => e.Employee_Id == id);
            if (employee != null)
            {
            db.employees.Remove(employee);
            db.SaveChanges();
            return 1;
            }
            return 0;
        }

        IEnumerable<EmployeeSalaryViewModel> IEmployeeRepository.GetEmployees()
        {
            var employeeSalaries = from e in db.employees
                                   join s in db.Salaries
                                   on e.Employee_Id equals s.Employee_id into salaryGroup
                                   from s in salaryGroup.DefaultIfEmpty()
                                   select new EmployeeSalaryViewModel
                                   {
                                       Employee = e,
                                       Salary = s
                                   };
            return employeeSalaries.ToList();
        }

        Employee IEmployeeRepository.SearchEmployees(int id)
        {
            var employee = db.employees.Where(x => x.Employee_Id == id).FirstOrDefault();
            return employee;
        }

        int IEmployeeRepository.UpdateEmployee(int Id,string Name)
        {
            var employee = db.employees.Where(x => x.Employee_Id == Id).FirstOrDefault();
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