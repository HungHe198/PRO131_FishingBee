using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class ProductDetail
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public float Length { get; set; }
        public float Weight { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string? Manufacturer { get; set; }
        public string? Warranty { get; set; }
        public string? Additional_info { get; set; }
        public string? Description { get; set; }

        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public ICollection<Cart_Product>? Cart_Products { get; set; }
        public ICollection<DailyRevenue>? DailyRevenues { get; set; }
        public ICollection<BillDetail>? BillDetails { get; set; }
        public ICollection<PurchaseHistory>? PurchaseHistories { get; set; }
        public ProductRevenue? ProductRevenue { get; set; }
        public WishList? WishList { get; set; }
        public Inventory? Inventory { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
