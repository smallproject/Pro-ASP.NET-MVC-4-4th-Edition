using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class Account
    {
        [Display(Name = "First name")]
        public string firstname { get; set; }

        [Display(Name = "Middle name")]
        public string middlename { get; set; }

        [Display(Name = "Last name")]
        public string lastname { get; set; }

        [Display(Name = "Gender")]
        public string gender { get; set; }

        [Display(Name = "Birthdate")]
        public DateTime birthdate { get; set; }

        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Display(Name = "check box to agree with conditions")]
        public bool agree { get; set; }
    }
}