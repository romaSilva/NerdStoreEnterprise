﻿using System.ComponentModel.DataAnnotations;

namespace Identity.API.Models
{
    public class UserLogin
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
