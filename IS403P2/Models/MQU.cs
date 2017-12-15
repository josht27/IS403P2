using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IS403P2.Models
{
    public class MQU
    {
        public IEnumerable<Mission> Mission { get; set; }
        public IEnumerable<MissionQuestions> MissionQuestions { get; set; }
        public IEnumerable<Users> Users { get; set; }
    }
}