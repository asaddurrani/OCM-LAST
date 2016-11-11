namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class OilFilterSearchRequest : GetPagedListRequest
    {
        public int? OilFilterId { get; set; }
        public int? OilFilterMakerCompanyId { get; set; }
        public string OilFilterMakerCompanyName { get; set; }
    }
}