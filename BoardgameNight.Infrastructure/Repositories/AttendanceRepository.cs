using BoardgameNight.Domain.Entities;
using BoardgameNight.Domain.Interfaces;
using BoardgameNight.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardgameNight.Infrastructure.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly ApplicationDbContext _context;

        public AttendanceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Attendance>> GetByUserIdAsync(string userId)
        {
            return await _context.Attendances
                .Where(a => a.UserId == userId)
                .ToListAsync();
        }
    }
}