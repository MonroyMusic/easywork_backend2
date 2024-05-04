using easywork_backend2.Entitys;
using Microsoft.AspNetCore.Identity;

namespace easywork_backend2.Database;

public static class UsersSeeders
{
    public static async Task LoadDataAsync(
        UserManager<UserEntity> userManager,
        RoleManager<IdentityRole> roleManager,
        ILoggerFactory loggerFactory
    )
    {
        try
        {
            if (!roleManager.Roles.Any())
            {
                await roleManager.CreateAsync(new IdentityRole("USER"));
                await roleManager.CreateAsync(new IdentityRole("ADMIN"));
            }

            if (!userManager.Users.Any())
            {
                var userAdmin = new UserEntity
                {
                    Email = "pao@me.com",
                    UserName = "paola"
                };

                await userManager.CreateAsync(userAdmin, "MiMamaMeMima001*");
                await userManager.AddToRoleAsync(userAdmin, "ADMIN");

                var normalUser = new UserEntity
                {
                    Email = "mperez@me.com",
                    UserName = "mperez@me.com"
                };

                await userManager.CreateAsync(normalUser, "MiMamaMeMima001*");
                await userManager.AddToRoleAsync(normalUser, "USER");

                var newAdmin = new UserEntity
                {
                    Email = "gmonroy@me.com",
                    UserName = "gonzalo"
                };

                await userManager.CreateAsync(newAdmin, "Temporal001*");
                await userManager.AddToRoleAsync(newAdmin, "ADMIN");
            }
        }
        catch (Exception e)
        {
            var logger = loggerFactory.CreateLogger<EasyWorkDbContext>();
            logger.LogError(e.Message);
        }
    }
}