using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class CategoryRevenue
    {
        public Guid Id { get; set; }
        public decimal TotalRevenue { get; set; }
        public float PercentageRevenueCategory { get; set; }
        public int TotalQuantityCategory { get; set; }
        public decimal TotalProfitCategory { get; set; }
        public Guid? CategoryId { get; set; }
        public Category? Category { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
