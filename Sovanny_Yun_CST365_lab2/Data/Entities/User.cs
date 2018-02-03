using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sovanny_Yun_CST356_Lab2.Data.Entities
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Display(Name = "Year In School")]
        public int YearInSchool { get; set; }

        public bool isValid()
        {
            if (FirstName != null && LastName != null && Email.Contains("@"))
                return true;
            else
                return false;
        }
    }
}