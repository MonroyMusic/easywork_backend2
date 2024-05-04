using easywork_backend2;
using easywork_backend2.Entitys;
using Microsoft.AspNetCore.Identity;
using easywork_backend2.Database;
var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);
startup.Configure(app, app.Environment);

using (var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider;
    var loggerFactory = service.GetRequiredService<ILoggerFactory>();

    try
    {
        var userManager = service.GetRequiredService<UserManager<UserEntity>>();
        var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();

        await UsersSeeders.LoadDataAsync(userManager, roleManager, loggerFactory);
    }
    catch (Exception e)
    {
        var logger = loggerFactory.CreateLogger<Program>();
        logger.LogError(e, "Error al inicializar datos.");
    }
}

app.Run();