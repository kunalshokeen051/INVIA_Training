
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]

        public int Id { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required")]
        [StringLength(15, ErrorMessage = "Max 15 Character Allowed")]

        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Age")]
        [Range(18, 45, ErrorMessage = "Age Should be min 18 and max 45")]

        public int Age { get; set; }
    }
}