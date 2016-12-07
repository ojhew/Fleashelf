using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Fleashelf003.Models
{
    public class DbUserAccount
    {
        public DbUserAccount()
        {
            Email = "";
            Password = "";
            Username = "";
            Phone = "";
            Campus = "";
            AboutMe = "";
        }


        [Key]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Required")]
        public string Email{ get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Required")]
        [Compare("Password",ErrorMessage = "Passwords do not match")]
        [Display(Name = "Compare Password")]
        public string ComparePassword { get; set; }

        [DataType(DataType.Text)]
        public string Username { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.Text)]
        public string Campus { get; set; }

        [DataType(DataType.MultilineText)]
        public string AboutMe { get; set; }




    }
}