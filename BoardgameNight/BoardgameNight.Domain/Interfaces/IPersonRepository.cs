using BoardgameNight.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoardgameNight.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAllAsync();
        Task<Person> GetByIdAsync(int id);
        Task AddAsync(Person person);
        Task UpdateAsync(Person person);
        Task DeleteAsync(int id);
    }
}