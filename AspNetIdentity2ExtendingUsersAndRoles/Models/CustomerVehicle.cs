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
    
    public partial class CustomerVehicle
    {
        public int CustomerVehicleId { get; set; }
        public int CustomerId { get; set; }
        public Nullable<long> VehicleId { get; set; }
        public string VehiclePlateAlphabets { get; set; }
        public string VehiclePlateNumbers { get; set; }
        public string VehiclePlateYear { get; set; }
        public Nullable<int> VehicleManufacturingYear { get; set; }
        public Nullable<int> VehicleDailyRunningKms { get; set; }
    
        public virtual VehicleModelMaker VehicleModelMaker { get; set; }
    }
}
