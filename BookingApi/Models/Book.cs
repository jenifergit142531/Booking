using System.ComponentModel.DataAnnotations;

namespace BookingApi.Models
{
    public class Book
    {
        [Key]
        public int BookingId { get; set; }
        public string BookingName { get; set; }
        public string MovieName { get; set; }
        
    }
}
