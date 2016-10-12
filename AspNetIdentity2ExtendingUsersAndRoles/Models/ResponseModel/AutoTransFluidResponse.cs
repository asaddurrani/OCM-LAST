using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class AutoTransFluidResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AutoTransFluidResponse()
        {
            AutoTransFluids = new List<AutoTransFuel>();
        }

        /// <summary>
        /// AutoTransFluid
        /// </summary>
        public IEnumerable<AutoTransFuel> AutoTransFluids { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}