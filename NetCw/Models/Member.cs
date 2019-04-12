    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NetCw.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your date of birth  ")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Please enter your gender ")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your PostCode")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "Please enter your telephone number")]
        public string Telephone { get; set; }

    }
}