using Domain.Entities;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TrainingController(TrainingRepository TrainingRepository) : Controller
{
    [HttpPost]
    public async Task<IActionResult> Create(Training Training)
    {
        await TrainingRepository.Create(Training);

        return Ok();
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await TrainingRepository.Get());
    }
}
