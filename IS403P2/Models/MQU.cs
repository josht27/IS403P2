using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace IS403P2.Models
{
    public class MQU
    {
        [DisplayName("Mission")]
        public Mission Mission { get; set; }

        [DisplayName("Mission Questions")]
        public IEnumerable<MissionQuestions> MissionQuestions { get; set; }

        [DisplayName("Users")]
        public Users Users { get; set; }
    }
}