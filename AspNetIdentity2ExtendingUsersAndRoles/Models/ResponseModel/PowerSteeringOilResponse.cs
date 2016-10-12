using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class PowerSteeringOilResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PowerSteeringOilResponse()
        {
            PowerSteeringOils = new List<PowerSterringOil>();
        }

        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<PowerSterringOil> PowerSteeringOils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}