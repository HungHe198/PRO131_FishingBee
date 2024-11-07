using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class ProductRevenue
    {
        public Guid Id { get; set; }
        public decimal TotalRevenue { get; set; }
        public float PercentageRevenueProduct { get; set; }
        public int TotalQuantityProduct { get; set; }
        public decimal TotalProfitProduct { get; set; }
        public Guid ProductDetailId { get; set; }
        public ProductDetail? ProductDetail { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
