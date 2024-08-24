using Domain.Entities;
using Domain.Models;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(UserRepository userRepository,
    UserManager<User> _userManager) : Controller
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] UserCreateRequest model)
    {
        if (ModelState.IsValid)
        {
            User user = new()
            {
                Email = model.Email,
                Sex = model.Sex,
                BirthDate = model.BirthDate,
                Weight = model.Weight,
                TargetWeight = model.TargetWeight,
                Height = model.Height,
                DifferentHours = model.DifferentHours,
                AllDaysHour = model.AllDaysHour,
                MondayTrainingHour = model.MondayTrainingHour,
                TuesdayTrainingHour = model.TuesdayTrainingHour,
                WednesdayTrainingHour = model.WednesdayTrainingHour,
                ThursdayTrainingHour = model.ThursdayTrainingHour,
                FridayTrainingHour = model.FridayTrainingHour,
                SaturdayTrainingHour = model.SaturdayTrainingHour,
                SundayTrainingHour = model.SundayTrainingHour,
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return Ok(new { Message = "User registered successfully" });
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        return BadRequest(ModelState);
    }

    [HttpPut]
    public async Task<IActionResult> Update(User user)
    {
        await userRepository.Update(user);

        return Ok();
    }
}
