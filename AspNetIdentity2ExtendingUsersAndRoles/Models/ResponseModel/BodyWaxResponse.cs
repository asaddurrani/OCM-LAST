using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class BodyWaxResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BodyWaxResponse()
        {
            BodyWaxs = new List<BodyWax>();
        }

        /// <summary>
        /// Body Wax
        /// </summary>
        public IEnumerable<BodyWax> BodyWaxs { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}