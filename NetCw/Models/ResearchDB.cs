using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NetCw.Models
{
    public class ResearchDB : DbContext    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Announcements> Announcements { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        // public System.Data.Entity.DbSet<NetCw.Models.Member> Members { get; set; }
    }
}