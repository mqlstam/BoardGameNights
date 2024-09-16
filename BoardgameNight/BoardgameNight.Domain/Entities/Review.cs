namespace BoardgameNight.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public required Person Reviewer { get; set; }
        public required BoardgameNightEvent Event { get; set; }
        public required string Comment { get; set; }
        public int Rating { get; set; } // 1-5 star rating
    }
}