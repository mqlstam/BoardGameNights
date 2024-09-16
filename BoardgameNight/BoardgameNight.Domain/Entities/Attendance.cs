using System;

namespace BoardgameNight.Domain.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int BoardgameNightId { get; set; }
        public BoardgameNight BoardgameNight { get; set; }
        public bool HasAttended { get; set; }
    }
}