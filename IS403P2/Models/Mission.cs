using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Mission ID")]
        public int missionID { get; set; }

        [DisplayName("Mission Name")]
        public string missionName { get; set; }

        [DisplayName("Mission President Name")]
        public string missionPresidentName { get; set; }

        [DisplayName("Mission Address")]
        public string missionAddress { get; set; }

        [DisplayName("Mission Language")]
        public string language { get; set; }

        [DisplayName("Mission Climate")]
        public string climate { get; set; }

        [DisplayName("Dominant Religion")]
        public string dominantReligion { get; set; }

        [DisplayName("Flag")]
        public string flag { get; set; }
    }
}