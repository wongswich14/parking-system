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
    public class ParkingSlotTypeConfiguration : IEntityTypeConfiguration<ParkingSlotType>
    {
        public void Configure(EntityTypeBuilder<ParkingSlotType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
