namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class MicroFibreSearchRequest : GetPagedListRequest
    {
        public int? MicroFibreId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}