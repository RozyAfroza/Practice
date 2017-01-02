using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HTMLHelperDataAnnotation.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide your name")]
        [DisplayName("Employee Name")]
        [StringLength(20,MinimumLength = 3)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide your name")]
        [EmailAddress]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",ErrorMessage = "Please provide valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please provide your name")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please provide your name")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Please provide your name")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please provide your name")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please provide your confirm password")]
        [DisplayName("Confirm Password")]
        [Compare("Password")]
        [NotMapped]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}