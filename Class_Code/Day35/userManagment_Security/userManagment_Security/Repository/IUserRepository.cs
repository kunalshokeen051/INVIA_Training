using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userManagment_Security.Models;

namespace userManagment_Security.Repository
{
    public interface IUserRepository
    {
       int CreateAccount(User user);

        bool LoginValidate(string UserName,  string Password);

    }
}
