using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PROJECT1.Models
{
   [Table("Users")]

    public class Users
    {
        [Key]
        [DisplayName("UserID")]
        public int UserID { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter Email")]
        public string UserEmail { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }

    }

}