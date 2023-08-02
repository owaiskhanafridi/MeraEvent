namespace MeraEvent.API.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;   
        public string Description { get; set; } = String.Empty;
        public int Rent { get; set; }

        //Navigation Property
        public Location Location { get; set; }
        public List<HallAmenities> HallAmenities { get; set; }

    }
}
