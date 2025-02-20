using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ParkingSystemDbContext: DbContext
    {
        public ParkingSystemDbContext(DbContextOptions<ParkingSystemDbContext> options)
            : base(options) { }

        public DbSet<ParkingSlotType> ParkingSlotTypes { get; set; }
        public DbSet<ParkingSlot> ParkingSlots { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Pricing> Pricings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
