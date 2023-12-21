using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class RestaurantRepo
    {
        public List<RestaurantModel> GetAllData()
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                var result = context.Restaurant.Select(x => new RestaurantModel()
                {

                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address,
                    Contact = x.Contact,

                }).ToList();
                return result;
            }
        }
        public int ResturantCreate(RestaurantModel model)
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                Restaurant restaurant = new Restaurant()
                {

                    Name = model.Name,
                    Address = model.Address,
                    Contact = model.Contact

                };
                var result = context.Restaurant.Add(restaurant);
                context.SaveChanges();
                return restaurant.Id;
            }

        }
        public bool DeleteData(int id)
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                var restaurant = context.Restaurant.FirstOrDefault(x => x.Id == id);
                if (restaurant != null)
                {
                    context.Restaurant.Remove(restaurant);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }
        public RestaurantModel GetDetails(int id)
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                var result = context.Restaurant.Where(x => x.Id == id).Select(x => new RestaurantModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address,
                    Contact = x.Contact
                }
                ).FirstOrDefault();

                return result;
            }
        }
        public bool UpdateData(int id, RestaurantModel model)
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                
                var restaurant = context.Restaurant.FirstOrDefault(x => x.Id == id);
                if (restaurant != null)
                {
                    restaurant.Name = model.Name;
                    restaurant.Address = model.Address;
                    restaurant.Contact = model.Contact;
                }

                context.SaveChanges();

                return true;
            }
        }



    }
}