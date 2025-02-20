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
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.LicensePlate)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.EntryTime)
                .IsRequired();

            builder.Property(x => x.ExitTime)
                .IsRequired(false);

            //builder.HasOne(x => x.ParkingSlot)
            //    .WithMany()
            //    .HasForeignKey(x => x.ParkingSlotId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
