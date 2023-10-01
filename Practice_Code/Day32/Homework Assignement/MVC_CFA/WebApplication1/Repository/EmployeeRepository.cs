using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
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
                                   on e.Employee_Id  equals s.Salary_Id into salaryGroup
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

        int IEmployeeRepository.UpdateEmployee(Employee editedData)
        {
            try
            {
                var existingEmployee = db.employees.Find(editedData.Employee_Id);

                if (existingEmployee != null)
                {
                  
                    existingEmployee.Name = editedData.Name;
                    existingEmployee.Email = editedData.Email;
                    existingEmployee.Department = editedData.Department;
                    existingEmployee.Age = editedData.Age;

               
                    if (existingEmployee.Salary == null)
                    {
                        existingEmployee.Salary = new Salary();
                    }
                    existingEmployee.Salary.CTC = editedData.Salary.CTC;
                    existingEmployee.Salary.Basic_Pay = editedData.Salary.Basic_Pay;
                    existingEmployee.Salary.Allowance = editedData.Salary.Allowance;
                    existingEmployee.Salary.EPF = editedData.Salary.EPF;
                    existingEmployee.Salary.ESIC = editedData.Salary.ESIC;

                   
                    db.SaveChanges();

                    return 1; 
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return -1; 
            }
        }
    }
}