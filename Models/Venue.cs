using System.ComponentModel.DataAnnotations;

namespace Venue_Booking_System.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        [Required]
        public string VenueName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
