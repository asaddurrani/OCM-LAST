using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class OilFilterResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OilFilterResponse()
        {
            OilFilters = new List<OilFilter>();
        }

        /// <summary>
        /// OilFilter
        /// </summary>
        public IEnumerable<OilFilter> OilFilters { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}