using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VagaBondTravelAPI.Models;

namespace VagaBond.TravelAPI.Data
{
    public class VagaBondTravelAPIContext : DbContext
    {
        public VagaBondTravelAPIContext (DbContextOptions<VagaBondTravelAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var entity = modelBuilder.Entity<Destination>();

            //entity.HasKey(e => e.Id);
            
            entity.Property(e => e.CityName).IsRequired();
            entity.Property(e => e.Country).IsRequired();

            entity.Property(e => e.Description).HasMaxLength(200);

            entity.Property(e => e.Rating).HasMaxLength(5);
            //entity.Property(e => e.Rating).HasMaxLength<;

        }
        public DbSet<VagaBondTravelAPI.Models.Destination> Destination { get; set; } = default!;
    }
}
