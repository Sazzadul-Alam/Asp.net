using DAL.EF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class ApiContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { set; get; }
        public DbSet<Semester> Semesters { set; get; }
        public DbSet<Student> Students { set; get; }
        public DbSet<Token> Tokens { set; get; }
    }
}
