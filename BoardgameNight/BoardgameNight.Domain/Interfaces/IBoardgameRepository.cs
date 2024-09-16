using BoardgameNight.Domain.Entities;

namespace BoardgameNight.Domain.Interfaces
{
    public interface IBoardgameRepository : IRepository<Boardgame>
    {
        Task<IEnumerable<Boardgame>> GetBoardgamesByGenreAsync(string genre);
    }
}