using BoardgameNight.Domain.Entities;
using BoardgameNight.Domain.Exceptions;
using BoardgameNight.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BoardgameNight.Web.Controllers
{
    public class BoardgameNightController : Controller
    {
        private readonly BoardgameNightService _boardgameNightService;

        public BoardgameNightController(BoardgameNightService boardgameNightService)
        {
            _boardgameNightService = boardgameNightService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(BoardgameNight boardgameNight, int organizerId)
        {
            try
            {
                var createdBoardgameNight = await _boardgameNightService.CreateBoardgameNightAsync(boardgameNight, organizerId);
                return RedirectToAction(nameof(Details), new { id = createdBoardgameNight.Id });
            }
            catch (DomainValidationException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(boardgameNight);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddAttendee(int boardgameNightId, int attendeeId)
        {
            try
            {
                await _boardgameNightService.AddAttendeeAsync(boardgameNightId, attendeeId);
                return RedirectToAction(nameof(Details), new { id = boardgameNightId });
            }
            catch (DomainValidationException ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction(nameof(Details), new { id = boardgameNightId });
            }
        }
    }
}