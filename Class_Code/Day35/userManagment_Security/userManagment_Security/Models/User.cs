using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace userManagment_Security.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
    }
}