namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class BrakeOilSearchRequest : GetPagedListRequest
    {
        public int? BrakeOilId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}