using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace userManagment_Security.Models
{
    public class LoginViewModel
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}