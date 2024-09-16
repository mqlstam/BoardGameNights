namespace BoardgameNight.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public required string Text { get; set; }
        public required Person Reviewer { get; set; }
        public required BoardgameNight BoardgameNight { get; set; }

        public bool IsValid() => Score >= 1 && Score <= 5;
    }
}