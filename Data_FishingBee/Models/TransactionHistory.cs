using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class TransactionHistory
    {
        public Guid Id { get; set; }
     
        public string TransactionType { get; set; }
        public string EmployeeName { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string CustomerName { get; set; }
        public Guid? PurchaseHistoryId { get; set; }
        public PurchaseHistory? PurchaseHistory { get; set; }
        public Guid? BillId { get; set; }
        public Bill? Bill { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
