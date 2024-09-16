using BoardgameNight.Application.Interfaces;
using BoardgameNight.Domain.Entities;
using BoardgameNight.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardgameNight.Application.Services
{
    public class BoardgameNightService : IBoardgameNightService
    {
        private readonly IBoardgameNightRepository _boardgameNightRepository;
        private readonly IAttendanceRepository _attendanceRepository;

        public BoardgameNightService(IBoardgameNightRepository boardgameNightRepository, IAttendanceRepository attendanceRepository)
        {
            _boardgameNightRepository = boardgameNightRepository;
            _attendanceRepository = attendanceRepository;
        }

        public async Task<IEnumerable<BoardgameNightViewModel>> GetAllBoardgameNightsAsync()
        {
            var nights = await _boardgameNightRepository.GetAllAsync();
            return nights.Select(MapToViewModel);
        }

        public async Task<IEnumerable<BoardgameNightViewModel>> GetParticipatingNightsAsync(string userId)
        {
            var attendances = await _attendanceRepository.GetByUserIdAsync(userId);
            var nightIds = attendances.Select(a => a.BoardgameNightId);
            var nights = await _boardgameNightRepository.GetByIdsAsync(nightIds);
            return nights.Select(MapToViewModel);
        }

        public async Task<IEnumerable<BoardgameNightViewModel>> GetOrganizedNightsAsync(string userId)
        {
            var nights = await _boardgameNightRepository.GetByOrganizerIdAsync(userId);
            return nights.Select(MapToViewModel);
        }

        private BoardgameNightViewModel MapToViewModel(BoardgameNight night)
        {
            return new BoardgameNightViewModel
            {
                Id = night.Id,
                Date = night.Date,
                Location = night.Location,
                OrganizerName = night.Organizer.Name // Assuming Organizer is loaded
            };
        }
    }
}