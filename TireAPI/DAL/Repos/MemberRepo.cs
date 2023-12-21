using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;
using DAL.EF.Models;

namespace DAL.Repos
{
    public class MemberRepo
    {
        public static List<Member> GetAllMember()
        {
            var db = new APIContext();
            return db.Members.ToList();
               
        }

        public static bool Create(Member m)
        {
            var db = new APIContext();
            db.Members.Add(m);
            return db.SaveChanges() > 0;
        }
    }
}
