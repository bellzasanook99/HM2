﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    class MdlAuth
    {
    }
    public class MdlLogin
    {
        [Required(ErrorMessage = "PhoneNumber is required")]
        [StringLength(15, ErrorMessage = "The PhoneNumber must be less than {1} characters.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }


        public string Email { get; set; }
    }
}
