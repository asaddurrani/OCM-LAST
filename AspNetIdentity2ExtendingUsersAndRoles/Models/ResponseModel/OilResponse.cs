using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class OilResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OilResponse()
        {
            Oils = new List<Oil>();
        }

        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<Oil> Oils { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}