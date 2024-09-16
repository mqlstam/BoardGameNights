using BoardgameNight.Domain.Entities;
using BoardgameNight.Domain.Interfaces;
using BoardgameNight.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardgameNight.Infrastructure.Repositories
{
    public class BoardgameNightRepository : IBoardgameNightRepository
    {
        private readonly ApplicationDbContext _context;

        public BoardgameNightRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BoardgameNight>> GetAllAsync()
        {
            return await _context.BoardgameNights
                .Include(bn => bn.Organizer)
                .ToListAsync();
        }

        public async Task<IEnumerable<BoardgameNight>> GetByIdsAsync(IEnumerable<int> ids)
        {
            return await _context.BoardgameNights
                .Include(bn => bn.Organizer)
                .Where(bn => ids.Contains(bn.Id))
                .ToListAsync();
        }

        public async Task<IEnumerable<BoardgameNight>> GetByOrganizerIdAsync(string organizerId)
        {
            return await _context.BoardgameNights
                .Include(bn => bn.Organizer)
                .Where(bn => bn.OrganizerId == organizerId)
                .ToListAsync();
        }
    }
}