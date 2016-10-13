using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class AirFilterRequest : GetPagedListRequest
    {
        public int? AirFilterId { get; set; }

    }
}