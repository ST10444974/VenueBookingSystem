using System.ComponentModel.DataAnnotations;

namespace Venue_Booking_System.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
