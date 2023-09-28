using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFinalDBF.Repository
{
    public class StudentRepository : IStudentRepository
    {
        StudentDBContext Context = new StudentDBContext();

        IEnumerable<Student> IStudentRepository.GetStudentData()
        {
            return Context.Students.ToList();
        }

        Student IStudentRepository.Search(int id)
        {
            var temp = Context.Students.Where(x => x.Id == id).FirstOrDefault(); 
            
            return temp;
        }
    }
}