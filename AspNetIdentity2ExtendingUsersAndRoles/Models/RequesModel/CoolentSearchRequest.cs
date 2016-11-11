namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class CoolentSearchRequest : GetPagedListRequest
    {
        public int? CoolentId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}