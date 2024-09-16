namespace BoardgameNight.Domain.Entities
{
    public class PotluckItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Person BroughtBy { get; set; }
        public required BoardgameNight BoardgameNight { get; set; }
        public bool IsLactoseFree { get; set; }
        public bool IsNutFree { get; set; }
        public bool IsVegetarian { get; set; }
        public bool ContainsAlcohol { get; set; }

        public bool IsSuitableFor(Person person)
        {
            return (!person.HasLactoseAllergy || IsLactoseFree) &&
                   (!person.HasNutAllergy || IsNutFree) &&
                   (!person.IsVegetarian || IsVegetarian) &&
                   (!person.AvoidAlcohol || !ContainsAlcohol);
        }
    }
}