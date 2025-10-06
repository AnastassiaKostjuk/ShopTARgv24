namespace ShopTARgv24.Models.Kindergarten
{
    public class KindergartenCreateUpdateViewModel
    {
        public Guid? Id { get; set; }
        public string? Group { get; set; }
        public int? ChildrenTotal { get; set; }
        public string? KindergartenName { get; set; }
        public string? Teacher { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
