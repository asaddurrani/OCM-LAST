//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspNetIdentity2ExtendingUsersAndRoles.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oil
    {
        public int OilId { get; set; }
        public string OilName { get; set; }
        public Nullable<int> OilMakerId { get; set; }
        public Nullable<int> OilAverageMilage { get; set; }
        public string OilPower { get; set; }
        public Nullable<double> OilPrice { get; set; }
        public string OilDescription { get; set; }
        public Nullable<int> OilNetWeightId { get; set; }
    
        public virtual OilMakerCompany OilMakerCompany { get; set; }
    }
}
