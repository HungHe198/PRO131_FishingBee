using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class PurchaseHistory
    {
        public Guid Id { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SupplierName { get; set; }
        public string AdminName { get; set; }
        public Guid AdminId { get; set; }
        public Admin? Admin { get; set; }
        public Guid ProductDetailId { get; set; }
        public ProductDetail? ProductDetail { get; set; }
        public Guid SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
        public TransactionHistory? TransactionHistory { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
