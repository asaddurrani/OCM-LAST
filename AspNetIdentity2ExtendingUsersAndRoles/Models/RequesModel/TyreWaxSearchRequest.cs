namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class TyreWaxSearchRequest : GetPagedListRequest
    {
        public int? TyreWaxId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}