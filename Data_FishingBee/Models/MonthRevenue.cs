using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class MonthRevenue
    {
        public Guid Id { get; set; }

        public string? Month { get; set; } // yyyy-MM || MM-yyyy
        public int? TotalQuantity { get; set; }
        public decimal? TotalOriginAmount { get; set; }
        public decimal? TotalDiscountAmount { get; set; }
        public decimal? TotalFinalAmount { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
