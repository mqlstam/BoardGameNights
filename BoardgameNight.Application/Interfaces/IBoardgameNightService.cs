public interface IBoardgameNightService
{
    Task<IEnumerable<BoardgameNightViewModel>> GetAllBoardgameNightsAsync();
    Task<IEnumerable<BoardgameNightViewModel>> GetParticipatingNightsAsync(string userId);
    Task<IEnumerable<BoardgameNightViewModel>> GetOrganizedNightsAsync(string userId);
    // ... other methods ...
}