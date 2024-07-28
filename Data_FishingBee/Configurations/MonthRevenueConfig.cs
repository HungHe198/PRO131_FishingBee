using Data_FishingBee.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Configurations
{
    public class MonthRevenueConfig : IEntityTypeConfiguration<MonthRevenue>
    {
        public void Configure(EntityTypeBuilder<MonthRevenue> builder)
        {
            builder.HasKey(x => x.Id);
        } 
        }
}
