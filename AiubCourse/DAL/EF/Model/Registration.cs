using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Registration
    {
        [Key]
        public int Id { set; get; }
        [ForeignKey("Student")]
        public int SId { set; get; }
        [ForeignKey("Course")]
        public int CId { set; get; }
        public string status { set; get; }
        [ForeignKey("Semester")]
        public int SeId { set; get; }
        public virtual Student Student { set; get; }
        public virtual Course Course { set; get; }
        public virtual Semester Semester { set; get; }

    }
}
