using MeraEvent.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeraEvent.API.Repositories.EntityFramework
{
    public class HallAmenitiesConfiguration : IEntityTypeConfiguration<HallAmenities>
    {
        public void Configure(EntityTypeBuilder<HallAmenities> builder)
        {
        }
    }
}
