using BoardgameNight.Domain.Entities;
using Xunit;
using System;

namespace BoardgameNight.Tests.Domain
{
    public class BoardgameNightEventTests
    {
        [Fact]
        public void Test1()
        {
            var organizer = new Person { Name = "Organizer" };
            var boardgameNightEvent = new BoardgameNightEvent
            {
                Location = "Test Location",
                Address = "Test Address",
                Organizer = organizer,
                // Set other required properties
            };

            var person1 = new Person { Name = "Person 1" };
            var person2 = new Person { Name = "Person 2" };

            // ... rest of your test code ...

            var review1 = new Review
            {
                Reviewer = person1,
                Event = boardgameNightEvent,
                Comment = "Great event!",
                // Set other required properties
            };

            // ... rest of your test code ...
        }

        // Update other test methods similarly
    }
}