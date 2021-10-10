﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Lab1.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        public System.DateTime BirthDate { get; set; }


    }
}
