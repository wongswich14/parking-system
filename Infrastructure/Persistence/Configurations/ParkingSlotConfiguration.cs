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
    public class ParkingSlotConfiguration : IEntityTypeConfiguration<ParkingSlot>
    {
        public void Configure(EntityTypeBuilder<ParkingSlot> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.SlotNumber)
                .IsRequired();

            builder.Property(x => x.IsOccupied)
                .HasDefaultValue(false);

            builder.Property(x => x.CreateDate)
                .HasDefaultValueSql("GETUTCDATE()"); // Valor por defecto en SQL Server

            //builder.HasOne(x => x.ParkingSlotType)
            //    .WithMany()
            //    .HasForeignKey(x => x.ParkingSlotTypeId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
