using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS403P2.Models
{
    [Table("Mission")]
    public class Mission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int missionID { get; set; }
        public string missionName { get; set; }
        public string missionPresidentName { get; set; }
        public string missionAddress { get; set; }
        public string language { get; set; }
        public string climate { get; set; }
        public string dominantReligion { get; set; }
        public string flag { get; set; }
    }
}