using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string? IDCardNumber { get; set; }
        public string Address { get; set; }
        public DateTime DoB { get; set; }
        public int LoyaltyPoints { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        
        //public ICollection<Bill>? Bill { get; set; }
        public Cart? Cart { get; set; }
        //public ICollection<CustomerSupport>? CustomerSupports { get; set; }
        public CustomerActivityLog? CustomerActivityLog { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
