using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Salary
    {

        [Key]
        public int Salary_Id { get; set; }

        [Required]
        public long CTC { get; set; }

        public long Basic_Pay { get; set; }

        public int ESIC { get; set; }

        public int EPF { get; set; }

        public int Allowance { get; set; }

        public int Bonus { get; set; }

        public int Income_Tax { get; set; }

        public long Mis_Deductions { get; set; }
    }
}
