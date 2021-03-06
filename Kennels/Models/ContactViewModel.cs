﻿using System.ComponentModel.DataAnnotations;

namespace Kennels.Models
{
    //View Model for the contact page
    public class ContactViewModel
    {
        [Required]
        public string EmailTo { get; set; }
        [Required, StringLength(30, MinimumLength = 4, ErrorMessage = "Must be between 4 and 30 characters.")]
        public string Name { get; set; }
        [Required, EmailAddress, Display(Name = "Email")]
        public string EmailFrom { get; set; }
        [Required]
        public string Message { get; set; }
    }
}