using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using userManagment_Security.Database;
using userManagment_Security.Models;

namespace userManagment_Security.Repository
{
    public class UserRepository : IUserRepository
    {

        private StudentDbContext Context = new StudentDbContext();

        int IUserRepository.CreateAccount(User user)
        {
            Context.Users.Add(user);
            return Context.SaveChanges();
        }

        bool IUserRepository.LoginValidate(string UserName, string Password)
        {
            var Result = Context.Users
                         .Where(m => m.UserName == UserName && m.Password == Password)
                         .FirstOrDefault();

            if(Result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}