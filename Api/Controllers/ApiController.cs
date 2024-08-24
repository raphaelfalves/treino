using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class ApiController(SignInManager<User> signInManager) : ControllerBase
    {
        [HttpPost("/logout")]
        [Authorize]
        public async Task<IResult> Logout(object empty)
        {
            if (empty != null)
            {
                await signInManager.SignOutAsync();
                return Results.Ok();
            }

            return Results.Unauthorized();
        }
    }
}
