using BoardgameNight.Domain.Entities;

namespace BoardgameNight.Domain.Interfaces
{
    public interface IBoardgameNightRepository : IRepository<Entities.BoardgameNight>
    {
        Task<IEnumerable<Entities.BoardgameNight>> GetUpcomingNightsAsync();
        Task<IEnumerable<Entities.BoardgameNight>> GetNightsByOrganizerAsync(int organizerId);
        Task<IEnumerable<Entities.BoardgameNight>> GetNightsByParticipantAsync(int participantId);
    }
}