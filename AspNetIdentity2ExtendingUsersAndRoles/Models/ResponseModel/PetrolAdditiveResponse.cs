using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class PetrolAdditiveResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PetrolAdditiveResponse()
        {
            PetrolAdditives = new List<PetrolAdditive>();
        }

        /// <summary>
        /// PetrolAdditive
        /// </summary>
        public IEnumerable<PetrolAdditive> PetrolAdditives { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}