namespace MeraEvent.API.Models
{
    public class HallAmenities
    {
        public int HallId { get; set; }
        public int AmenityId { get; set; }
        public float ExtraCost { get; set; }

        public Hall? Hall { get; set; }
        public Amenity? Amenity { get; set; }
    }
}
