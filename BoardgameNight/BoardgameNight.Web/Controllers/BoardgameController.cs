using BoardgameNight.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoardgameNight.Web.Controllers
{
    public class BoardgameController : Controller
    {
        private readonly IBoardgameRepository _boardgameRepository;

        public BoardgameController(IBoardgameRepository boardgameRepository)
        {
            _boardgameRepository = boardgameRepository;
        }

        public async Task<IActionResult> Index()
        {
            var boardgames = await _boardgameRepository.GetAllAsync();
            return View(boardgames);
        }

        // Implement other actions using the repository methods
    }
}