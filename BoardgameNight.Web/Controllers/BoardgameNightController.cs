using BoardgameNight.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace BoardgameNight.Web.Controllers
{
    public class BoardgameNightController : Controller
    {
        private readonly IBoardgameNightService _boardgameNightService;
        private readonly UserManager<ApplicationUser> _userManager;

        public BoardgameNightController(IBoardgameNightService boardgameNightService, UserManager<ApplicationUser> userManager)
        {
            _boardgameNightService = boardgameNightService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var viewModel = new BoardgameNightIndexViewModel
            {
                AllNights = await _boardgameNightService.GetAllBoardgameNightsAsync(),
                ParticipatingNights = currentUser != null 
                    ? await _boardgameNightService.GetParticipatingNightsAsync(currentUser.Id)
                    : Enumerable.Empty<BoardgameNightViewModel>(),
                OrganizedNights = currentUser != null
                    ? await _boardgameNightService.GetOrganizedNightsAsync(currentUser.Id)
                    : Enumerable.Empty<BoardgameNightViewModel>()
            };
            return View(viewModel);
        }
    }
}