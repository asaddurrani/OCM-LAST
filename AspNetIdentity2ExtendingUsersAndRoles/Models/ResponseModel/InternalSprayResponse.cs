using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class InternalSprayResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public InternalSprayResponse()
        {
            InternalSprays = new List<InternalSpray>();
        }

        /// <summary>
        /// InternalSpray
        /// </summary>
        public IEnumerable<InternalSpray> InternalSprays { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}