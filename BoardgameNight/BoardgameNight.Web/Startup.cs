public void ConfigureServices(IServiceCollection services)
{
    // ... existing code ...

    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

    services.AddDefaultIdentity<Person>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddEntityFrameworkStores<ApplicationDbContext>();

    services.AddControllersWithViews();
    services.AddRazorPages();

    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "BoardgameNight API", Version = "v1" });
    });

    // ... existing code ...
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    // ... existing code ...

    app.UseRouting();
    app.UseAuthentication();
    app.UseAuthorization();

    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BoardgameNight API v1"));

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        endpoints.MapRazorPages();
    });

    // ... existing code ...
}