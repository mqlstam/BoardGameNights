namespace BoardgameNight.Domain.Entities
{
    public class Food
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public List<BoardgameNight> BoardgameNights { get; set; } = new List<BoardgameNight>();
        public bool IsLactoseFree { get; set; }
        public bool IsNutFree { get; set; }
        public bool IsVegetarian { get; set; }

        public bool IsSuitableFor(Person person)
        {
            return (!person.HasLactoseAllergy || IsLactoseFree) &&
                   (!person.HasNutAllergy || IsNutFree) &&
                   (!person.IsVegetarian || IsVegetarian);
        }
    }
}