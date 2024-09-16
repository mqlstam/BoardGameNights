public class BoardgameNightIndexViewModel
{
    public IEnumerable<BoardgameNightViewModel> AllNights { get; set; }
    public IEnumerable<BoardgameNightViewModel> ParticipatingNights { get; set; }
    public IEnumerable<BoardgameNightViewModel> OrganizedNights { get; set; }
}