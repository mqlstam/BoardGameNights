using BoardgameNight.Domain.Entities;

namespace BoardgameNight.Domain.Interfaces
{
    public interface IReviewRepository : IRepository<Review>
    {
        Task<IEnumerable<Review>> GetReviewsByOrganizerAsync(int organizerId);
        Task<double> GetAverageScoreForOrganizerAsync(int organizerId);
    }
}