using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("MyConnectionString") { }

        //Student will be the actual table name in DB
        public DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.StudentViewModel> StudentViewModels { get; set; }
    }
}



