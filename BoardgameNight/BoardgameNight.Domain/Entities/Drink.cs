namespace BoardgameNight.Domain.Entities
{
    public class Drink
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public List<BoardgameNight> BoardgameNights { get; set; } = new List<BoardgameNight>();
        public bool ContainsAlcohol { get; set; }

        public bool IsSuitableFor(Person person)
        {
            return !person.AvoidAlcohol || !ContainsAlcohol;
        }
    }
}