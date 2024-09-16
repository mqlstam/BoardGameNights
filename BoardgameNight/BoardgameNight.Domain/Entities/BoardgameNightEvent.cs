using System;
using System.Collections.Generic;
using System.Linq;

namespace BoardgameNight.Domain.Entities
{
    public class BoardgameNightEvent
    {
        public int Id { get; set; }
        public required string Location { get; set; }
        public required string Address { get; set; }
        public required Person Organizer { get; set; }
        public DateTime Date { get; set; }
        public List<Person> Participants { get; set; } = new List<Person>();
        public List<Boardgame> Boardgames { get; set; } = new List<Boardgame>();
        public List<Food> FoodOptions { get; set; } = new List<Food>();
        public List<Drink> DrinkOptions { get; set; } = new List<Drink>();
        public bool IsPotluck { get; set; }
        public List<PotluckItem> PotluckItems { get; set; } = new List<PotluckItem>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Attendance> Attendances { get; set; } = new List<Attendance>();
        public bool IsAdultsOnly { get; set; }
        public int MaxPlayers { get; set; }

        public bool CanAddParticipant() => Participants.Count < MaxPlayers;

        public double AverageRating => Reviews.Any() ? Reviews.Average(r => r.Rating) : 0;
    }
}