namespace AspNetIdentity2ExtendingUsersAndRoles.Models.RequesModel
{
    public class SeatFoamSpraySearchRequest : GetPagedListRequest
    {
        public int? SeatFoamSprayId { get; set; }
        public string BrandName { get; set; }
        public int? Type { get; set; }
    }
}