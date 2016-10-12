using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class AirFilterResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AirFilterResponse()
        {
            AirFilters = new List<AirFilter>();
        }

        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<AirFilter> AirFilters { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}