using System.Collections.Generic;
using BoardgameNight.Domain.Entities;

namespace BoardgameNight.Domain.Interfaces
{
    public interface IBoardgameNightRepository
    {
        IEnumerable<BoardgameNightEvent> GetAllBoardgameNights();
        BoardgameNightEvent GetBoardgameNight(int id);
        void AddBoardgameNight(BoardgameNightEvent boardgameNight);
        void UpdateBoardgameNight(BoardgameNightEvent boardgameNight);
    }
}