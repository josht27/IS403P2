using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IS403P2.Models
{
    public class MQU
    {
        public Mission Mission { get; set; }
        public IEnumerable<MissionQuestions> MissionQuestions { get; set; }
        public Users Users { get; set; }
    }
}