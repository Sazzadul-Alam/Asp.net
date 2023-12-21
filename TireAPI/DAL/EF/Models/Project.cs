using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        [ForeignKey("Member")]
        public int MId { get; set; }
        [ForeignKey("Supervisor")]
        public int SId { get; set; }
        public virtual Member Member { get; set; }
        public virtual Supervisor Supervisor { get; set; }

    }
}
