namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class AutoTransFluidSearchRequest : GetPagedListRequest
    {
        public int? AutoTransId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}