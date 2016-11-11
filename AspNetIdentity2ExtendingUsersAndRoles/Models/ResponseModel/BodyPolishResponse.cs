using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class BodyPolishResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BodyPolishResponse()
        {
            bodyPolishes = new List<BodyPolish>();
        }

        /// <summary>
        /// BodyPolish
        /// </summary>
        public IEnumerable<BodyPolish> bodyPolishes { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}