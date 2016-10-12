using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class SeatFoamSprayResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SeatFoamSprayResponse()
        {
            SeatFoamSprays = new List<SeatFoamSpray>();
        }

        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<SeatFoamSpray> SeatFoamSprays { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}