//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BB_FINAL_EV.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string ApiName { get; set; }
        public string URL { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual ICollection<Post> Posts { get; set; }
    }
}