using System;
using System.ComponentModel.DataAnnotations;
using BoardgameNight.Domain.Exceptions;

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
        public int MinAge { get; set; }
        public int PlayTimeInMinutes { get; set; }
        public bool IsAdultOnly { get; set; }
        public BoardgameType Type { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new DomainValidationException("Name is required.");

            if (string.IsNullOrWhiteSpace(Description))
                throw new DomainValidationException("Description is required.");

            if (string.IsNullOrWhiteSpace(Genre))
                throw new DomainValidationException("Genre is required.");

            if (MinPlayers < 1)
                throw new DomainValidationException("Minimum players must be at least 1.");

            if (MaxPlayers < MinPlayers)
                throw new DomainValidationException("Maximum players must be greater than or equal to minimum players.");

            if (MinAge < 0)
                throw new DomainValidationException("Minimum age cannot be negative.");

            if (PlayTimeInMinutes <= 0)
                throw new DomainValidationException("Play time must be greater than 0 minutes.");

            if (IsAdultOnly && MinAge < 18)
                throw new DomainValidationException("Adult-only games must have a minimum age of 18.");
        }
    }

    public enum BoardgameType
    {
        BoardGame,
        CardGame,
        DiceGame,
        RolePlayingGame
    }
}