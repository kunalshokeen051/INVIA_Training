using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationFinalDBF.Repository
{
    public interface IStudentRepository
    {
        Student Search(int id);
        IEnumerable<Student> GetStudentData();
    }
}
