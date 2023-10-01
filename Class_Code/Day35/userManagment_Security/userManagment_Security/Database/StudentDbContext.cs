using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using userManagment_Security.Models;

namespace userManagment_Security.Database
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(): base("MyConnection")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<LoginViewModel> LoginViewModels { get; set; }
    }
}