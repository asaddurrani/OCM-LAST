namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class PetrolAdditiveSearchRequest : GetPagedListRequest
    {
        public int? PetrolAdditiveId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}