using Application.Enums;
using Domain.Entities.Basic;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Seeds
{
    public static class DefaultSeedData
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var data = await userManager.Users.Where(x => x.PhoneNumber == "09120000000").FirstOrDefaultAsync();

            if (data is null)
            {
                var superAdmin = new ApplicationUser()
                {
                    FirstName = "SuperAdmin",
                    LastName = "SuperAdmin",
                    Email = "SuperAdmin@Rahbord.com",
                    PhoneNumber = "09120000000",
                    UserName = "SuperAdmin",
                    CompanyName = "Rahbord"
                };

                var resultSuperAdmin = await userManager.CreateAsync(superAdmin, "SuperAdmin@123456789");

                var admin = new ApplicationUser()
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "Admin@Rahbord.com",
                    PhoneNumber = "09121111111",
                    UserName = "Admin",
                    CompanyName = "Rahbord"
                };

                var resultAdmin = await userManager.CreateAsync(admin, "Admin@123456789");

                var user = new ApplicationUser()
                {
                    FirstName = "User",
                    LastName = "User",
                    Email = "User@Rahbord.com",
                    PhoneNumber = "09122222222",
                    UserName = "User",
                    CompanyName = "Rahbord"
                };

                var resultUser = await userManager.CreateAsync(user, "User@123456789");

                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = Roles.SuperAdmin.ToString()
                });

                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = Roles.Admin.ToString()
                });

                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = Roles.Customer.ToString()
                });

                await userManager.AddToRoleAsync(superAdmin, Roles.SuperAdmin.ToString());

                await userManager.AddToRoleAsync(admin, Roles.Admin.ToString());

                await userManager.AddToRoleAsync(admin, Roles.Customer.ToString());
            }
        }
    }
}