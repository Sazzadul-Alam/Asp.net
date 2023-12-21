using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class UserRepo
    {
        public List<TypeModel> GetType()
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                var result = context.Type.Select(x => new TypeModel { Id = x.Id, Name = x.Name }).ToList();
                return result;
            }
        }
        public int AddUser(UserModel model)
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                User user = new User()
                {
                    Email = model.Email,
                    Password = model.Password,
                    TypeId = model.TypeId
                };

                var result = context.User.Add(user);
                context.SaveChanges();
                return user.Id;
            }

        }
        public int LoginUser(UserModel model)
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                var result = context.User.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
                if (result != null)
                {
                    return (int)result.TypeId;
                }
            }
            return 0;
        }
    }
}