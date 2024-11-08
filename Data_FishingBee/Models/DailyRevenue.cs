﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class DailyRevenue
    {
        public Guid Id { get; set; }
        public string? NameProduct { get; set; }
        public string? Description { get; set; }
        public int? TotalQuantity { get; set; }
        public decimal? OriginAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? FinalAmount { get; set; }
        public Guid ProductDetailId { get; set; }
        public ProductDetail? ProductDetail { get; set; }
        public int? WeekOfYear { get; set; } // thứ tự trong năm thay vì trong tháng
        public WeekRevenue? WeekRevenue { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
