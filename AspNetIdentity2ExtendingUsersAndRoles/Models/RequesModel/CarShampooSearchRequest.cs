namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class CarShampooSearchRequest : GetPagedListRequest
    {
        public int? CarShampooId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}