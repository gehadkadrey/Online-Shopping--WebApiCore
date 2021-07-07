﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace J6.Models
{
    public class ForgetPasswordVM
    {

        [Required(ErrorMessage = "Required Email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}