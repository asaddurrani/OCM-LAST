namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class BodyWaxSearchRequest : GetPagedListRequest
    {
        public int? BodyWaxId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}