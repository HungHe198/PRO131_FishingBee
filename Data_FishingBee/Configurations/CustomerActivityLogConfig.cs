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
    public class CustomerActivityLogConfig : IEntityTypeConfiguration<CustomerActivityLog>
    {
        public void Configure(EntityTypeBuilder<CustomerActivityLog> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
