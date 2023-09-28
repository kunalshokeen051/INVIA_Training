using System;
using System.Collections.Generic;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class EmployeeManagmentContext : DbContext
    {
 
     public  EmployeeManagmentContext() : base("MyConnection")
        {
    
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Salary> Salaries { get; set; }
    }
}