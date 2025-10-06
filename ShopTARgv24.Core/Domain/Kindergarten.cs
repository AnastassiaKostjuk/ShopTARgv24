namespace ShopTARgv24.Core.Domain
{

    public class Kindergarten
    {
        public Guid Id { get; set; }
        public string Group { get; set; }
        public int ChildrenTotal { get; set; }
        public string KindergartenName { get; set; }
        public string Teacher { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
