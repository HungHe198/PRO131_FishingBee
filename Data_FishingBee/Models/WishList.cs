using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class WishList
    {
        public Guid Id { get; set; }
        public int QuantitySaled { get; set; }
        public decimal Profit { get; set; }
        public float ProfitPercentage { get; set; }
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
