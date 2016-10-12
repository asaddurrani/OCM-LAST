using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class MicroFibreResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MicroFibreResponse()
        {
            MicroFibres = new List<MicroFibre>();
        }

        /// <summary>
        /// MicroFibre
        /// </summary>
        public IEnumerable<MicroFibre> MicroFibres { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}