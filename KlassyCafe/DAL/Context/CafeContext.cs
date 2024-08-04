using KlassyCafe.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace KlassyCafe.DAL.Context
{
    public class CafeContext  : DbContext
    {
        public CafeContext(DbContextOptions<CafeContext> options):base(options){}

        
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
