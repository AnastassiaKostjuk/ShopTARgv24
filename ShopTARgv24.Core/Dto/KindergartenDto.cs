using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTARgv24.Core.Dto
{
    public class KindergartenDto
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
