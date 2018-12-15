using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace ActorStudio.Models
{
    public static class IdentityInitialize
    {

        //Load user accounts
        public static async void LoadUserAccounts()
        {
            var ds = new ApplicationDbContext();
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(ds));

            if (userManager.Users.Count() == 0)
            {
                var papa = new ApplicationUser { UserName = "kartuzov@rogers.com", Email = "kartuzov@rogers.com" };
                var yura = new ApplicationUser { UserName = "y.kartuzov@gmail.com", Email = "y.kartuzov@gmail.com" };

                var papaResult = await userManager.CreateAsync(papa, "Canada98");
                var yuraResult = await userManager.CreateAsync(yura, "AppleFam");

                if (papaResult.Succeeded)
                {
                    await userManager.AddClaimAsync(papa.Id, new Claim(ClaimTypes.Email, "kartuzov@rogers.com"));
                    await userManager.AddClaimAsync(papa.Id, new Claim(ClaimTypes.Role, "Admin"));
                    await userManager.AddClaimAsync(papa.Id, new Claim(ClaimTypes.GivenName, "Andrew"));
                    await userManager.AddClaimAsync(papa.Id, new Claim(ClaimTypes.Surname, "Kartuzov"));
                }

                if (yuraResult.Succeeded)
                {
                    await userManager.AddClaimAsync(yura.Id, new Claim(ClaimTypes.Email, "y.kartuzov@gmail.com"));
                    await userManager.AddClaimAsync(yura.Id, new Claim(ClaimTypes.Role, "Developer"));
                    await userManager.AddClaimAsync(yura.Id, new Claim(ClaimTypes.Role, "Admin"));
                    await userManager.AddClaimAsync(yura.Id, new Claim(ClaimTypes.GivenName, "Yuriy"));
                    await userManager.AddClaimAsync(yura.Id, new Claim(ClaimTypes.Surname, "Kartuzov"));
                }
            }
        }
    }
}