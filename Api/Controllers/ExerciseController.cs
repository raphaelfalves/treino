using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ExerciseController(ExerciseRepository exerciseRepository) : Controller
{
    [HttpPost]
    public async Task<IActionResult> Create(Exercise exercise)
    {
        await exerciseRepository.Create(exercise);

        return Ok();
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await exerciseRepository.Get());
    }
}
