using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class CollectionRequestRepo
    {
        public List<CollectionRequestModel> GetData()
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                var res = context.CollectionRequest.Select(x => new CollectionRequestModel()
                {

                    Id=x.Id,
                    RestaurantId = x.RestaurantId,
                    PreservationTime = x.PreservationTime,
                    CollectionDate = x.CollectionDate,
                    CollectionStatus = x.CollectionStatus,

                }).ToList();
                return res;
            }
        }
        public int CollectionRequestCreate(CollectionRequestModel model)
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                CollectionRequest collectionRequest = new CollectionRequest()
                {

                   RestaurantId=model.RestaurantId,
                   PreservationTime=model.PreservationTime,
                   CollectionDate=model.CollectionDate,
                   CollectionStatus=model.CollectionStatus

                };
                var result = context.CollectionRequest.Add(collectionRequest);
                context.SaveChanges();
                return collectionRequest.Id;
            }

        }
        public CollectionRequestModel GetDetails(int id)
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                var result = context.CollectionRequest.Where(x => x.Id == id).Select(x => new CollectionRequestModel()
                {
                    Id = x.Id,
                    RestaurantId = x.RestaurantId,
                    PreservationTime = x.PreservationTime,
                    CollectionDate = x.CollectionDate,
                    CollectionStatus = x.CollectionStatus,
                }
                ).FirstOrDefault();

                return result;
            }
        }
        public bool UpdateData(int id, CollectionRequestModel model)
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {

                var collectionRequest = context.CollectionRequest.FirstOrDefault(x => x.Id == id);
                if (collectionRequest != null)
                {
                    collectionRequest.RestaurantId = model.RestaurantId;
                    collectionRequest.PreservationTime = model.PreservationTime;
                    collectionRequest.CollectionDate = model.CollectionDate;
                    collectionRequest.CollectionStatus = model.CollectionStatus;
                }

                context.SaveChanges();

                return true;
            }
        }
        public bool DeleteData(int id)
        {
            using (var context = new ZeroHungerAssignmentEntities())
            {
                var collectionRequest = context.CollectionRequest.FirstOrDefault(x => x.Id == id);
                if (collectionRequest != null)
                {
                    context.CollectionRequest.Remove(collectionRequest);
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
}