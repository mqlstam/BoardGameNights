using System.Collections.Generic;
using BoardgameNight.Domain.Entities;
using BoardgameNight.Domain.Interfaces;

namespace BoardgameNight.Domain.Services
{
    public class BoardgameNightService : IBoardgameNightService
    {
        private readonly IBoardgameNightRepository _repository;

        public BoardgameNightService(IBoardgameNightRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<BoardgameNightEvent> GetAllBoardgameNights()
        {
            return _repository.GetAllBoardgameNights();
        }

        public BoardgameNightEvent GetBoardgameNight(int id)
        {
            return _repository.GetBoardgameNight(id);
        }

        // Implement other methods as needed
    }
}