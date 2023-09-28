
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Name")]
        [StringLength(20, ErrorMessage = "Name Should be max 20 length")]
        public string Name { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Age")]
        [Range(18, 45, ErrorMessage = "Age Should be min 18 and max 45")]
        public int Age { get; set; }

    }
}