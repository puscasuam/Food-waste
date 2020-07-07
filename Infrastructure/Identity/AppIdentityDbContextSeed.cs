using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Carmen",
                    Email = "carmen@test.com",
                    UserName = "carmen@test.com",
                    Address = new Address
                    {
                        FirstName = "Carmen",
                        LastName = "Pop",
                        Street = "Bucuresti",
                        City = "Cluj",
                        State = "CJ",
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }


    }
}
