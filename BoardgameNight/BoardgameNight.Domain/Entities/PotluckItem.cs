namespace BoardgameNight.Domain.Entities
{
    public class PotluckItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Person BroughtBy { get; set; }
        public PotluckItemType Type { get; set; }
    }

    public enum PotluckItemType
    {
        Food,
        Drink
    }
}