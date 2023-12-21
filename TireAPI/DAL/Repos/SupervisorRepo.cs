using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.Models;
using DAL.EF;

namespace DAL.Repos
{
    public class SupervisorRepo
    {
        public static List<Supervisor> GetAllMember()
        {
            var db = new APIContext();
            return db.Supervisors.ToList();

        }
    }
}
