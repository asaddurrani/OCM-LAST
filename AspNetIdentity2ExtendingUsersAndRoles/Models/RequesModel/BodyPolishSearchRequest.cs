namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class BodyPolishSearchRequest : GetPagedListRequest
    {
        public int? BodyPolishId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}