using System;

namespace BoardgameNight.Domain.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public required Person Participant { get; set; }
        public required BoardgameNightEvent Event { get; set; }
        public bool HasAttended { get; set; }
        public bool IsNoShow { get; set; }
        public DateTime? CheckInTime { get; set; }
    }
}