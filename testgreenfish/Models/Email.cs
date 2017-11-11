using System;
using System.ComponentModel.DataAnnotations;

namespace testgreenfish.Models
{
    public class Email
    {

        public int emailId { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string address { get; set; }
    }
}