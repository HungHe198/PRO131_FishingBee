using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public Guid DailyRevenuesId { get; set; }
        public ICollection<DailyRevenue>? DailyRevenues { get; set; }
        public ICollection<Cart_Product>? Cart_Products { get; set; }
        public ICollection<Product_Category>? Product_Categories { get; set; }
        public ICollection<BillDetail>? BillDetails { get; set; }
        public ProductDetail? ProductDetail { get; set; }
        public ProductRevenue? ProductRevenue { get; set; }
        public Inventory? Inventory{ get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
