using System.Collections.Generic;
using BoardgameNight.Domain.Entities;

namespace BoardgameNight.Domain.Interfaces
{
    public interface IBoardgameNightService
    {
        IEnumerable<BoardgameNightEvent> GetAllBoardgameNights();
        BoardgameNightEvent GetBoardgameNight(int id);
        // Add other method signatures as needed
    }
}