namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class EngineSpraySearchRequest : GetPagedListRequest
    {
        public int? EngineSprayId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}