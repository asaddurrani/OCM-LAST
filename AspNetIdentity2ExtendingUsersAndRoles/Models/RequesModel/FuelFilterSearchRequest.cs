namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class FuelFilterSearchRequest : GetPagedListRequest
    {
        public int? FuelFilterId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}