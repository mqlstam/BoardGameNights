namespace BoardgameNight.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Street { get; set; }
        public required string HouseNumber { get; set; }
        public required string City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public ICollection<BoardgameNight> OrganizedNights { get; set; } = new List<BoardgameNight>();
        public ICollection<BoardgameNight> ParticipatedNights { get; set; } = new List<BoardgameNight>();
        // Add other properties as needed

        // Domain validation
        public bool CanOrganize() => IsAdult();

        public bool IsAdult() => CalculateAge() >= 18;

        private int CalculateAge()
        {
            var currentDate = DateTimeOffset.UtcNow.Date;
            return (int)((currentDate - DateOfBirth.Date).TotalDays / 365.25);
        }

        public bool CanRegister() => CalculateAge() >= 16;

        public bool CanParticipateInAdultOnlyNight() => IsAdult();

        public bool CanParticipateInNightOnDate(DateTime nightDate)
        {
            return ParticipatedNights.All(n => n.Date.Date != nightDate.Date);
        }

        public bool HasLactoseAllergy { get; set; }
        public bool HasNutAllergy { get; set; }
        public bool IsVegetarian { get; set; }
        public bool AvoidAlcohol { get; set; }
        public List<Review> GivenReviews { get; set; } = new List<Review>();
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}