using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS403P2.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("User ID")]
        public int userID { get; set; }

        [DisplayName("User Email")]
        public string userEmail { get; set; }

        [DisplayName("User Password")]
        public string userPassword { get; set; }

        [DisplayName("User First Name")]
        public string userFirstName { get; set; }

        [DisplayName("User Last Name")]
        public string userLastName { get; set; }    

    }
}