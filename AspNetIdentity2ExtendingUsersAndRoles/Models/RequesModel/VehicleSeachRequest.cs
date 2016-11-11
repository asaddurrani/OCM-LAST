namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class VehicleSeachRequest : GetPagedListRequest
    {
        public int? VehicleId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}