using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class StudentRepository : IStudentRepository
    {
        StudentContext Context = new StudentContext();

        IEnumerable<Student> IStudentRepository.GetStudentData()
        {
            return Context.Students.ToList();
        }

        bool IStudentRepository.Delete(int id)
        {
            Student student = Context.Students.Find(id);
            Context.Students.Remove(student);
            Context.SaveChanges();
            return true;
        }

        Student IStudentRepository.Details(int id)
        {
            var employees = Context.Students.Find(id);
            return employees;
        }
    }
}