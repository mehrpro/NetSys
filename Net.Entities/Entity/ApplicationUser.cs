﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Net.Entities.Entity
{
    public class ApplicationUser : BaseClass<int>
    {
        public ApplicationUser()
        {
            ID = new int();
            Registered = DateTime.Now;
            IsActive = true;
            IsDelete = false;
        }


        [Required]
        [MaxLength(250)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MinLength(120)]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(11)]
        public string PhoneNumber { get; set; }
    }
}