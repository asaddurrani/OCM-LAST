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
            BodyPolishs = new List<BodyPolish>();
        }

        /// <summary>
        /// BodyPolish
        /// </summary>
        public IEnumerable<BodyPolish> BodyPolishs { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}