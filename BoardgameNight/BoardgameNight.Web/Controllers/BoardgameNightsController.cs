using Microsoft.AspNetCore.Mvc;
using BoardgameNight.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using BoardgameNight.Domain.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Linq;

namespace BoardgameNight.Web.Controllers
{
    [Authorize]
    public class BoardgameNightsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BoardgameNightsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _context.People.FindAsync(userId);

            var viewModel = new BoardgameNightIndexViewModel
            {
                AllNights = await _context.BoardgameNights.Include(bn => bn.Organizer).ToListAsync(),
                ParticipatingNights = await _context.BoardgameNights
                    .Include(bn => bn.Organizer)
                    .Where(bn => bn.Participants.Contains(user))
                    .ToListAsync(),
                OrganizedNights = await _context.BoardgameNights
                    .Include(bn => bn.Organizer)
                    .Where(bn => bn.Organizer == user)
                    .ToListAsync()
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var boardgameNight = await _context.BoardgameNights
                .Include(bn => bn.Organizer)
                .Include(bn => bn.Participants)
                .Include(bn => bn.Boardgames)
                .Include(bn => bn.FoodOptions)
                .Include(bn => bn.DrinkOptions)
                .Include(bn => bn.PotluckItems)
                .Include(bn => bn.Reviews)
                .Include(bn => bn.Attendances)
                .FirstOrDefaultAsync(bn => bn.Id == id);

            if (boardgameNight == null)
            {
                return NotFound();
            }

            return View(boardgameNight);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(int boardgameNightId)
        {
            var boardgameNight = await _context.BoardgameNights
                .Include(bn => bn.Participants)
                .FirstOrDefaultAsync(bn => bn.Id == boardgameNightId);

            if (boardgameNight == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _context.People.FindAsync(userId);

            if (boardgameNight.CanAddParticipant() && !boardgameNight.Participants.Contains(user))
            {
                boardgameNight.Participants.Add(user);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Details), new { id = boardgameNightId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarkAttendance(int boardgameNightId, int participantId, bool hasAttended)
        {
            var boardgameNight = await _context.BoardgameNights
                .Include(bn => bn.Attendances)
                .FirstOrDefaultAsync(bn => bn.Id == boardgameNightId);

            if (boardgameNight == null)
            {
                return NotFound();
            }

            var attendance = boardgameNight.Attendances.FirstOrDefault(a => a.Participant.Id == participantId);

            if (attendance == null)
            {
                var participant = await _context.People.FindAsync(participantId);
                attendance = new Attendance
                {
                    Participant = participant,
                    Event = boardgameNight,
                    HasAttended = hasAttended,
                    IsNoShow = !hasAttended,
                    CheckInTime = hasAttended ? DateTime.Now : null
                };
                boardgameNight.Attendances.Add(attendance);
            }
            else
            {
                attendance.HasAttended = hasAttended;
                attendance.IsNoShow = !hasAttended;
                attendance.CheckInTime = hasAttended ? DateTime.Now : null;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new { id = boardgameNightId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReview(int boardgameNightId, Review review)
        {
            var boardgameNight = await _context.BoardgameNights.FindAsync(boardgameNightId);
            if (boardgameNight == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _context.People.FindAsync(userId);

            review.Reviewer = user;
            review.Event = boardgameNight;
            boardgameNight.Reviews.Add(review);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = boardgameNightId });
        }

        [HttpGet]
        public async Task<IActionResult> AttendanceHistory(int organizerId)
        {
            var organizer = await _context.People.FindAsync(organizerId);
            if (organizer == null)
            {
                return NotFound();
            }

            var attendanceHistory = await _context.Attendances
                .Include(a => a.Event)
                .Include(a => a.Participant)
                .Where(a => a.Event.Organizer.Id == organizerId)
                .ToListAsync();

            return View(attendanceHistory);
        }

        // Add other actions (Create, Edit, Delete) as needed

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BoardgameNightEvent boardgameNight)
        {
            if (!ModelState.IsValid)
            {
                return View(boardgameNight);
            }

            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var organizer = await _context.People.FindAsync(userId);

                if (organizer == null)
                {
                    return NotFound("Organizer not found.");
                }

                boardgameNight.Organizer = organizer;
                _context.Add(boardgameNight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred while creating the boardgame night. Please try again.");
                // Log the exception
                return View(boardgameNight);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPotluckItem(int boardgameNightId, PotluckItem potluckItem)
        {
            var boardgameNight = await _context.BoardgameNights
                .Include(bn => bn.PotluckItems)
                .FirstOrDefaultAsync(bn => bn.Id == boardgameNightId);

            if (boardgameNight == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _context.People.FindAsync(userId);

            potluckItem.BroughtBy = user;
            boardgameNight.PotluckItems.Add(potluckItem);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = boardgameNightId });
        }
    }
}