using BoardgameNight.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoardgameNight.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Domain.Entities.BoardgameNight> BoardgameNights { get; set; }
        public DbSet<Boardgame> Boardgames { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<PotluckItem> PotluckItems { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Drink> Drinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Domain.Entities.BoardgameNight>()
                .HasOne(bn => bn.Organizer)
                .WithMany(p => p.OrganizedNights)
                .HasForeignKey("OrganizerId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Person)
                .WithMany()
                .HasForeignKey(a => a.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.BoardgameNight)
                .WithMany()
                .HasForeignKey(a => a.BoardgameNightId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Person>()
                .HasMany(p => p.ParticipatedNights)
                .WithMany(bn => bn.Participants)
                .UsingEntity<Attendance>(
                    j => j
                        .HasOne(a => a.BoardgameNight)
                        .WithMany()
                        .HasForeignKey(a => a.BoardgameNightId),
                    j => j
                        .HasOne(a => a.Person)
                        .WithMany()
                        .HasForeignKey(a => a.PersonId),
                    j =>
                    {
                        j.HasKey(a => a.Id);
                        j.ToTable("Attendances");
                    });

            modelBuilder.Entity<Drink>()
                .Property(d => d.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Food>()
                .Property(f => f.Price)
                .HasPrecision(18, 2);
        }
    }
}