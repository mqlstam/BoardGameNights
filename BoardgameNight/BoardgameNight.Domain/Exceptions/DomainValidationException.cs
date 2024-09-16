using System;

namespace BoardgameNight.Domain.Exceptions
{
    public class DomainValidationException : Exception
    {
        public DomainValidationException(string message) : base(message)
        {
        }
    }
}