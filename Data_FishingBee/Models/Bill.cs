using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public decimal TotalPrice { get; set; }
        public string CustomerName { get; set; }
        public ICollection<BillDetail>? BillDetails { get; set; }
        public TransactionHistory? TransactionHistory { get; set; }
        //public Guid CustomerId { get; set; }
        //public Customer? Customer { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public Guid PromotionId { get; set; }
        public Promotion? Promotion { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }

    }
}
