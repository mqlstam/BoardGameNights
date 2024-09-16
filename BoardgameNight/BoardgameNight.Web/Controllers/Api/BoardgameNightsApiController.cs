using BoardgameNight.Domain.Entities;
using BoardgameNight.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoardgameNight.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardgameNightsApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BoardgameNightsApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BoardgameNightsApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BoardgameNightEvent>>> GetBoardgameNights()
        {
            return await _context.BoardgameNights.ToListAsync();
        }

        // GET: api/BoardgameNightsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BoardgameNightEvent>> GetBoardgameNight(int id)
        {
            var boardgameNight = await _context.BoardgameNights.FindAsync(id);

            if (boardgameNight == null)
            {
                return NotFound();
            }

            return boardgameNight;
        }

        // POST: api/BoardgameNightsApi
        [HttpPost]
        public async Task<ActionResult<BoardgameNightEvent>> PostBoardgameNight(BoardgameNightEvent boardgameNight)
        {
            _context.BoardgameNights.Add(boardgameNight);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBoardgameNight), new { id = boardgameNight.Id }, boardgameNight);
        }

        // PUT: api/BoardgameNightsApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoardgameNight(int id, BoardgameNightEvent boardgameNight)
        {
            if (id != boardgameNight.Id)
            {
                return BadRequest();
            }

            _context.Entry(boardgameNight).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoardgameNightExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/BoardgameNightsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoardgameNight(int id)
        {
            var boardgameNight = await _context.BoardgameNights.FindAsync(id);
            if (boardgameNight == null)
            {
                return NotFound();
            }

            _context.BoardgameNights.Remove(boardgameNight);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BoardgameNightExists(int id)
        {
            return _context.BoardgameNights.Any(e => e.Id == id);
        }
    }
}