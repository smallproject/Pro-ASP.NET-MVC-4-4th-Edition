using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class Register
    {
        [Display(Name = "Username: ")]
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        
        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        
        [Display(Name = "First name: ")]
        [Required(ErrorMessage = "First name is required.")]
        public string Firstname { get; set; }

        [Display(Name = "Last name: ")]
        [Required(ErrorMessage = "Last name is required.")]
        public string Lastname { get; set; }

        [Display(Name = "Gender: ")]
        [Required(ErrorMessage = "Gender is required.")]
        public string gender { get; set; }

        [Display(Name = "Birthdate:")]
        [Required(ErrorMessage = "Birthdate is required.")]
        public DateTime birthdate { get; set; }
    }
}