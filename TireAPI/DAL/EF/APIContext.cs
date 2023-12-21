using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.Models;

namespace DAL.EF
{
    class APIContext:DbContext
    {
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
