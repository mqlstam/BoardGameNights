using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BoardgameNight.Domain.Entities
{
    public class Person : IdentityUser
    {
        public required string Name { get; set; }  // Add 'required' here
        public DateTime BirthDate { get; set; }  // Changed from DateOfBirth
        public string? Gender { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string? City { get; set; }
        public List<BoardgameNightEvent> OrganizedEvents { get; set; } = new List<BoardgameNightEvent>();
        public List<BoardgameNightEvent> ParticipatedEvents { get; set; } = new List<BoardgameNightEvent>();
        public bool HasLactoseAllergy { get; set; }
        public bool HasNutAllergy { get; set; }
        public bool IsVegetarian { get; set; }
        public bool AvoidAlcohol { get; set; }
    }
}