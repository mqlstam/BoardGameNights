using BoardgameNight.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BoardgameNight.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<Person>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BoardgameNightEvent> BoardgameNightEvents { get; set; }  // Changed from BoardgameNights
        public DbSet<Boardgame> Boardgames { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<PotluckItem> PotluckItems { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add any additional configuration here
        }
    }
}