//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharmacyManagmentSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public product()
        {
            this.productdetails = new HashSet<productdetail>();
        }
    
        public int productId { get; set; }
        public string productName { get; set; }
        public string ProductManf { get; set; }
        public int catadoryId { get; set; }
    
        public virtual category category { get; set; }
        public virtual ICollection<productdetail> productdetails { get; set; }
    }
}