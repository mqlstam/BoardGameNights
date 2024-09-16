namespace BoardgameNight.Domain.Entities
{
    public class Boardgame
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Genre { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public List<BoardgameNight> BoardgameNights { get; set; } = new List<BoardgameNight>();
        public bool IsAdultOnly { get; set; }
        public GameType Type { get; set; }
        public string? PhotoUrl { get; set; }

        public bool IsValidForNight(BoardgameNight night)
        {
            return night.Participants.Count >= MinPlayers && night.Participants.Count <= MaxPlayers;
        }
    }

    public enum GameType
    {
        CardGame,
        BoardGame,
        // Add other types as needed
    }
}