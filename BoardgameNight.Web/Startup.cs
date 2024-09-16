public void ConfigureServices(IServiceCollection services)
{
    // ... existing code ...

    services.AddScoped<IBoardgameNightService, BoardgameNightService>();
    services.AddScoped<IBoardgameNightRepository, BoardgameNightRepository>();
    services.AddScoped<IAttendanceRepository, AttendanceRepository>();

    // ... existing code ...
}