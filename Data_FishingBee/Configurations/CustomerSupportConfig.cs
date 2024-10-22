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
    public class CustomerSupportConfig : IEntityTypeConfiguration<CustomerSupport>
    {
        public void Configure(EntityTypeBuilder<CustomerSupport> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasOne(x => x.Customer)
            //    .WithMany(c => c.CustomerSupports)
            //    .HasForeignKey(x => x.CustomerId)
            //    .OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(x => x.Employee)
            //    .WithMany(c => c.CustomerSupports)
            //    .HasForeignKey(x => x.EmployeeId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
