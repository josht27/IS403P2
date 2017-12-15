using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IS403P2.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [DisplayName("Mission Question ID")]
        public int missionQuestionID { get; set; }

        [DisplayName("Question")]
        public string question { get; set; }

        [DisplayName("Answer")]
        public string answer { get; set; }

        [DisplayName("Mission ID")]
        public int? missionID { get; set; }
        [ForeignKey("missionID")]

        [DisplayName("Mission")]
        public virtual Mission Mission { get; set; }

        [DisplayName("User ID")]
        public int? userID { get; set; }
        [ForeignKey("userID")]

        [DisplayName("User")]
        public virtual Users User { get; set; }
    }
}