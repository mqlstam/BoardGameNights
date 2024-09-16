using BoardgameNight.Domain.Entities;
using System.Collections.Generic;

namespace BoardgameNight.Web.Models
{
    public class BoardgameNightIndexViewModel
    {
        public List<BoardgameNightEvent> AllNights { get; set; }
        public List<BoardgameNightEvent> ParticipatingNights { get; set; }
        public List<BoardgameNightEvent> OrganizedNights { get; set; }
    }
}