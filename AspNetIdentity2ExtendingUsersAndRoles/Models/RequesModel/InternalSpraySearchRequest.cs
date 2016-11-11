namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class InternalSpraySearchRequest : GetPagedListRequest
    {
        public int? InternalSprayId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}