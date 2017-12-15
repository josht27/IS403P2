using IS403P2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IS403P2.DAL
{
    public class IS403P2Context : DbContext
    {
        public IS403P2Context() : base("IS403P2Context")
        {

        }

        public DbSet<Mission> Mission { get; set; }
        public DbSet<MissionQuestions> MissionQuestions { get; set; }
        public DbSet<Users> Users { get; set; }
        
    }
}