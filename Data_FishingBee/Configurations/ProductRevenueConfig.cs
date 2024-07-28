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
    public class ProductRevenueConfig : IEntityTypeConfiguration<ProductRevenue>
    {
        public void Configure(EntityTypeBuilder<ProductRevenue> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
