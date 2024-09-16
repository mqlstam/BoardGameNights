using BoardgameNight.Domain.Entities;

namespace BoardgameNight.Domain.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person?> GetByEmailAsync(string email);
    }
}