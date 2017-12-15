using System;
using System.Collections.Generic;
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
        public int userID { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public string userFirstName { get; set; }
        public string userLastName { get; set; }    

    }
}