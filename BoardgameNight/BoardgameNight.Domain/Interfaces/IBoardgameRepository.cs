using BoardgameNight.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoardgameNight.Domain.Interfaces
{
    public interface IBoardgameRepository
    {
        Task<IEnumerable<Boardgame>> GetAllAsync();
        Task<Boardgame> GetByIdAsync(int id);
        Task AddAsync(Boardgame boardgame);
        Task UpdateAsync(Boardgame boardgame);
        Task DeleteAsync(int id);
    }
}