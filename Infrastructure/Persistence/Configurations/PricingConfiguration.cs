using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    public class PricingConfiguration : IEntityTypeConfiguration<Pricing>
    {
        public void Configure(EntityTypeBuilder<Pricing> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.HourlyRate)
                .HasPrecision(10, 2)
                .IsRequired();

            builder.Property(x => x.DailyRate)
                .HasPrecision(10, 2)
                .IsRequired();
        }
    }
}
