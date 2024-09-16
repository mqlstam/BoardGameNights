public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<BoardgameNight> BoardgameNights { get; set; }
    public DbSet<Attendance> Attendances { get; set; }

    // ... other DbSet properties ...
}