using MeraEvent.API.Models;
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
        }
}
