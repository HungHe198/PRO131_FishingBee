using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public int RoleLevel { get; set; }
        public string RoleName { get; set; }
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }
        public ICollection<Admin>? Admins { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public ICollection<Customer>? Customers { get; set; }

        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
