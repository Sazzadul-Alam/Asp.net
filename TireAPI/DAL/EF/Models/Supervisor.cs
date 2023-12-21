using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Supervisor
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public Supervisor()
        {
            Projects = new List<Project>();
        }
    }
}
