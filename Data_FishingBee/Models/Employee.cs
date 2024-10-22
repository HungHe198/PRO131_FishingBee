using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string StaffCode { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string? IDCardNumber { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public ICollection<Bill>? Bills { get; set; }
        //public ICollection<CustomerSupport>? CustomerSupports { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
