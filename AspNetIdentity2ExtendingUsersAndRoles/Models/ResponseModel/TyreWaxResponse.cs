using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class TyreWaxResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TyreWaxResponse()
        {
            TyreWaxs = new List<TyreWax>();
        }

        /// <summary>
        /// Oils
        /// </summary>
        public IEnumerable<TyreWax> TyreWaxs { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}