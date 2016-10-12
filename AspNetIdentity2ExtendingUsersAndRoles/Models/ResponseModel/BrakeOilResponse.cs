using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class BrakeOilResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BrakeOilResponse()
        {
            BrakeOils = new List<BrakeOil>();
        }

        /// <summary>
        /// BrakeOil
        /// </summary>
        public IEnumerable<BrakeOil> BrakeOils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}