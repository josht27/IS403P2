using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS403P2.Models
{
    public class Mission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int missionID { get; set; }
        public String missionName { get; set; }
        public String missionPresidentName { get; set; }
        public String missionAddress { get; set; }
        public String language { get; set; }
        public String climate { get; set; }
        public String dominateReligion { get; set; }
        public String flag { get; set; }
    }
}