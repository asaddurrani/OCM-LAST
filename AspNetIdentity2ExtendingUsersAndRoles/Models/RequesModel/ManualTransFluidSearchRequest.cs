namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class ManualTransFluidSearchRequest : GetPagedListRequest
    {
        public int? ManualTransFluidId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}