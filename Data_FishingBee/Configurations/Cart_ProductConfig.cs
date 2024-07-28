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
    public class Cart_ProductConfig : IEntityTypeConfiguration<Cart_Product>
    {
        public void Configure(EntityTypeBuilder<Cart_Product> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
