using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IS403P2.Models
{
    public class MissionQuestions
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int missionQuestionID { get; set; }
        [ForeignKey("missionID")]
        public int missionID { get; set; }
        [ForeignKey("userID")]
        public int userID { get; set; }
        public String question { get; set; }
        public String answer { get; set; }

    }
}