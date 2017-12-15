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
        public int missionQuestionID { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

        public int? missionID { get; set; }
        [ForeignKey("missionID")]
        public virtual Mission Mission { get; set; }

        public int? userID { get; set; }
        [ForeignKey("userID")]
        public virtual Users User { get; set; }
    }
}