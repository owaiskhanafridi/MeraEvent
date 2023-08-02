using MeraEvent.API.Models;
using MeraEvent.API.Repositories.EntityFramework;
using Microsoft.EntityFrameworkCore;


namespace MeraEvent.API.Repositories
{
    public class MeraEventDBContext : DbContext
    {
        public MeraEventDBContext(DbContextOptions<MeraEventDBContext> options) : base(options)
        {
        }

        public DbSet<Hall> Halls { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<HallAmenities> HallAmenities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //hall-location 1-to-1
            modelBuilder.Entity<Hall>()
                .HasOne<Location>(x => x.Location)
                .WithOne(x => x.Hall)
                .HasForeignKey<Location>(x => x.HallId);

            modelBuilder.Entity<HallAmenities>()
                .HasKey(e => new { e.HallId, e.AmenityId });

            //hall-amenities m-to-m 
            modelBuilder.Entity<HallAmenities>()
                .HasOne(x => x.Hall)
                .WithMany(s => s.HallAmenities)
                .HasForeignKey(x => x.HallId);

            modelBuilder.Entity<HallAmenities>()
                .HasOne(x => x.Amenity)
                .WithMany(s => s.HallAmenities)
                .HasForeignKey(x => x.AmenityId);


            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeraEventDBContext).Assembly);
        }
    }



}
