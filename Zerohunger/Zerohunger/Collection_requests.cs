//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zerohunger
{
    using System;
    using System.Collections.Generic;
    
    public partial class Collection_requests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Collection_requests()
        {
            this.Collection_Logs = new HashSet<Collection_Logs>();
        }
    
        public int Request_id { get; set; }
        public Nullable<int> Restaurant_id { get; set; }
        public Nullable<System.DateTime> Maximum_preservation_time { get; set; }
        public Nullable<System.DateTime> Collection_date { get; set; }
        public string Collection_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collection_Logs> Collection_Logs { get; set; }
        public virtual Restaurants Restaurants { get; set; }
        public virtual Food_items Food_items { get; set; }
    }
}
