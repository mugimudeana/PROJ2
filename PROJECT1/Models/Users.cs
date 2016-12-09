using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJECT1.Models
{
   [Table("Users")]

    public class Users
    {
       [Key]
       [HiddenInput(DisplayValue = false)]
        [DisplayName("UserID")]
        public int UserID { get; set; }

   
        [DisplayName("Email")]
        public string UserEmail { get; set; }

    
        [DisplayName("Password")]
        public string Password { get; set; }

 
        [DisplayName("First Name")]
        public string FirstName { get; set; }

 
        [DisplayName("Last Name")]
        public string LastName { get; set; }

    }

}