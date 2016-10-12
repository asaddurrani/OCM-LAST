using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class CoolentResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CoolentResponse()
        {
            Coolents = new List<Coolent>();
        }

        /// <summary>
        /// Coolent
        /// </summary>
        public IEnumerable<Coolent> Coolents { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}