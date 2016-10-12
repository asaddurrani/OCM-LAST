using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class EngineSprayResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EngineSprayResponse()
        {
            EngineSprays = new List<EngineSpray>();
        }

        /// <summary>
        /// EngineSpray
        /// </summary>
        public IEnumerable<EngineSpray> EngineSprays { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }\
    }
}