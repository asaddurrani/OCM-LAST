namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class PowerSteeringOilSearchRequest : GetPagedListRequest
    {
        public int? PowerSteeringOilId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}