using System;
using System.Collections.Generic;

namespace BoardgameNight.Domain.Entities
{
    public class BoardgameNight
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public required string Location { get; set; }
        public required string Address { get; set; }
        public int MaxPlayers { get; set; }
        public required Person Organizer { get; set; }
        public List<Person> Participants { get; set; } = new List<Person>();
        public List<Boardgame> Boardgames { get; set; } = new List<Boardgame>();
        public List<Food> FoodOptions { get; set; } = new List<Food>();
        public List<Drink> DrinkOptions { get; set; } = new List<Drink>();
        public bool IsPotluck { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Attendance> Attendances { get; set; } = new List<Attendance>();
        public bool IsAdultsOnly { get; set; }

        // Domain validation
        public bool CanAddParticipant() => Participants.Count < MaxPlayers;

        public bool CanAddParticipant(Person person)
        {
            return CanAddParticipant() && 
                   (!IsAdultsOnly || person.IsAdult()) && 
                   person.CanParticipateInNightOnDate(Date);
        }

        public bool CanBeModified() => Participants.Count == 0;

        public void AddBoardgame(Boardgame boardgame)
        {
            Boardgames.Add(boardgame);
            if (boardgame.IsAdultOnly)
            {
                IsAdultsOnly = true;
            }
        }
    }
}