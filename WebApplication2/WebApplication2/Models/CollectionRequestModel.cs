using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CollectionRequestModel
    {
        public int Id { get; set; }
        public Nullable<int> RestaurantId { get; set; }
        public string PreservationTime { get; set; }
        public Nullable<System.DateTime> CollectionDate { get; set; }
        public string CollectionStatus { get; set; }

        public virtual Restaurant Restaurant { get; set; }
    }
}