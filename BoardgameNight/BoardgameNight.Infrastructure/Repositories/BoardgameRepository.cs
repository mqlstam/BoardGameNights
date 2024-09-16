using BoardgameNight.Domain.Entities;
using BoardgameNight.Domain.Interfaces;
using BoardgameNight.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardgameNight.Infrastructure.Repositories
{
    public class BoardgameRepository : IBoardgameRepository
    {
        private readonly ApplicationDbContext _context;

        public BoardgameRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Boardgame>> GetAllAsync()
        {
            return await _context.Boardgames.ToListAsync();
        }

        public async Task<Boardgame> GetByIdAsync(int id)
        {
            return await _context.Boardgames.FindAsync(id);
        }

        public async Task AddAsync(Boardgame boardgame)
        {
            await _context.Boardgames.AddAsync(boardgame);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Boardgame boardgame)
        {
            _context.Boardgames.Update(boardgame);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var boardgame = await _context.Boardgames.FindAsync(id);
            if (boardgame != null)
            {
                _context.Boardgames.Remove(boardgame);
                await _context.SaveChangesAsync();
            }
        }
    }
}