protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Attendance>()
        .HasOne(a => a.Person)
        .WithMany(p => p.Attendances)
        .HasForeignKey(a => a.PersonId)
        .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<Attendance>()
        .HasOne(a => a.BoardgameNight)
        .WithMany(b => b.Attendances)
        .HasForeignKey(a => a.BoardgameNightId)
        .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<BoardgameNight>()
        .HasOne(bn => bn.Organizer)
        .WithMany()
        .HasForeignKey(bn => bn.OrganizerId)
        .OnDelete(DeleteBehavior.Restrict);

    // Other configurations...
}