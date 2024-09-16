using BoardgameNight.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BoardgameNight.Infrastructure.Data
{
    public static class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Check if the database is already seeded
                if (context.Boardgames.Any())
                {
                    return;   // Database has been seeded
                }

                context.Boardgames.AddRange(
                    new Boardgame
                    {
                        Name = "Catan",
                        Description = "Settle, trade, build in this classic strategy game",
                        Genre = "Strategy",
                        MinPlayers = 3,
                        MaxPlayers = 4,
                        IsAdultOnly = false,
                        Type = BoardgameType.BoardGame
                    },
                    new Boardgame
                    {
                        Name = "Monopoly",
                        Description = "Buy, sell, dream and scheme your way to riches",
                        Genre = "Family",
                        MinPlayers = 2,
                        MaxPlayers = 8,
                        IsAdultOnly = false,
                        Type = BoardgameType.BoardGame
                    }
                );

                var person1 = new Person
                {
                    Name = "John Doe",
                    BirthDate = new DateTime(1990, 1, 1), // Use BirthDate instead of DateOfBirth
                    Gender = "Male",
                    Street = "Main Street",
                    HouseNumber = "123",
                    City = "New York",
                    // ... other properties ...
                };

                var person2 = new Person
                {
                    Name = "Jane Smith",
                    BirthDate = new DateTime(1985, 5, 15), // Use BirthDate instead of DateOfBirth
                    Gender = "Female",
                    Street = "Broadway",
                    HouseNumber = "456",
                    City = "Los Angeles",
                    // ... other properties ...
                };

                context.People.AddRange(person1, person2);

                var boardgameNight1 = new BoardgameNightEvent
                {
                    Date = DateTime.Now.AddDays(7),
                    Location = "Community Center",
                    Address = "789 Park Ave, New York, NY",
                    MaxPlayers = 8,
                    Organizer = person1,
                    IsAdultsOnly = false
                };

                var boardgameNight2 = new BoardgameNightEvent
                {
                    Date = DateTime.Now.AddDays(14),
                    Location = "Local Library",
                    Address = "101 Book St, Los Angeles, CA",
                    MaxPlayers = 6,
                    Organizer = person2,
                    IsAdultsOnly = true
                };

                context.BoardgameNightEvents.AddRange(boardgameNight1, boardgameNight2);

                var attendance1 = new Attendance
                {
                    Participant = person1,
                    Event = boardgameNight1,
                    HasAttended = true,
                    CheckInTime = DateTime.Now.AddHours(-2)
                };

                var attendance2 = new Attendance
                {
                    Participant = person2,
                    Event = boardgameNight1,
                    IsNoShow = true
                };

                boardgameNight1.Attendances.Add(attendance1);
                boardgameNight1.Attendances.Add(attendance2);

                context.Attendances.AddRange(attendance1, attendance2);

                context.SaveChanges();
            }
        }

        public static void SeedData(ApplicationDbContext context)
        {
            if (!context.People.Any())
            {
                var person1 = new Person
                {
                    Name = "John Doe",
                    BirthDate = new DateTime(1990, 1, 1), // Use BirthDate instead of DateOfBirth
                    Gender = "Male",
                    Street = "Main Street",
                    HouseNumber = "123",
                    City = "New York",
                    // ... other properties ...
                };

                var person2 = new Person
                {
                    Name = "Jane Smith",
                    BirthDate = new DateTime(1985, 5, 15), // Use BirthDate instead of DateOfBirth
                    Gender = "Female",
                    Street = "Broadway",
                    HouseNumber = "456",
                    City = "Los Angeles",
                    // ... other properties ...
                };

                context.People.AddRange(person1, person2);
                context.SaveChanges();
            }

            if (!context.BoardgameNightEvents.Any())
            {
                var event1 = new BoardgameNightEvent
                {
                    Location = "Community Center",
                    Address = "123 Main St",
                    Organizer = context.People.First(),
                    Date = DateTime.Now.AddDays(7),
                    // ... other properties ...
                };

                var event2 = new BoardgameNightEvent
                {
                    Location = "Local Library",
                    Address = "456 Oak Ave",
                    Organizer = context.People.Skip(1).First(),
                    Date = DateTime.Now.AddDays(14),
                    // ... other properties ...
                };

                context.BoardgameNightEvents.AddRange(event1, event2);
                context.SaveChanges();
            }

            // ... seed other entities ...
        }
    }
}