using Microsoft.AspNetCore.Mvc;
using BoardgameNight.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using BoardgameNight.Web.Models; // Add this line
using BoardgameNight.Domain.Entities; // Add this line if not already present

namespace BoardgameNight.Web.Controllers
{
    public class BoardgameNightsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BoardgameNightsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var boardgameNights = await _context.BoardgameNights.Include(bn => bn.Organizer).ToListAsync();
            return View(boardgameNights);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BoardgameNightViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var boardgameNight = new BoardgameNight.Domain.Entities.BoardgameNight
                {
                    Date = viewModel.Date,
                    Location = viewModel.Address,
                    Address = viewModel.Address, // Add this line
                    Organizer = new Person
                    {
                        Name = $"{viewModel.HostFirstName} {viewModel.HostLastName}",
                        Email = viewModel.HostEmail,
                        Street = "Unknown",
                        HouseNumber = "Unknown",
                        City = "Unknown"
                    }
                };

                _context.BoardgameNights.Add(boardgameNight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }
    }
}