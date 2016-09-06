namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class OilSearchRequest : GetPagedListRequest
    {
        public int? OilId { get; set; }
        public int? OilMakerCompany { get; set; }
    }
}