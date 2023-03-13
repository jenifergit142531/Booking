using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace BookingApi.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Bookings { get; set; }
    }
}
