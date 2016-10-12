using System.Collections.Generic;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.ResponseModel
{
    public class CarShampooResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CarShampooResponse()
        {
            CarShampoos = new List<CarShampoo>();
        }

        /// <summary>
        /// CarShampoo
        /// </summary>
        public IEnumerable<CarShampoo> CarShampoos { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }
    }
}