using BoardgameNight.Domain.Entities;

namespace BoardgameNight.Domain.Interfaces
{
    public interface IAttendanceRepository : IRepository<Attendance>
    {
        Task<IEnumerable<Attendance>> GetAttendancesByPersonAsync(int personId);
        Task<int> GetNoShowCountForPersonAsync(int personId);
    }
}