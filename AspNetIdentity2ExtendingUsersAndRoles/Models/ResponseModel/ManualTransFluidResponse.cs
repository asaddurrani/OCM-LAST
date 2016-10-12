using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class ManualTransFluidResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ManualTransFluidResponse()
        {
            ManualTransFluids = new List<ManualTransFuel>();
        }

        /// <summary>
        /// ManualTransFluid
        /// </summary>
        public IEnumerable<ManualTransFuel> ManualTransFluids { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}