using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROJECT1.Models;
using System.Data.Entity;


namespace PROJECT1.DAL
{
    public class MissionSiteContext : DbContext
    {

        public MissionSiteContext(): base("MissionSiteContext")
        {

        }

        public DbSet<MissionQuestions> MissionQuestion { get; set; }
        public DbSet<Missions> Mission { get; set; }
        public DbSet<Users> User { get; set; }


    }
}