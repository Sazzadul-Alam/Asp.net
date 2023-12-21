using DAL.EF.Model;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class UserRepo : Repo, IRepo<UserRepo, String, bool>, IAuth
    {
        public Student Authenticate(int Id, string username, string password)
        {
            var data = from u in db.Students
                       where u.Username.Equals(username)
                       && u.Password.Equals(password)
                       select u;
            return data.SingleOrDefault();
        }

        public bool Create(UserRepo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<UserRepo> Get()
        {
            throw new NotImplementedException();
        }

        public UserRepo Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(UserRepo obj)
        {
            throw new NotImplementedException();
        }
    }
}
