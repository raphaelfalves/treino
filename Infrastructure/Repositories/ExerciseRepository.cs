using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ExerciseRepository(ApplicationDbContext context)
{
    public async Task Create(Exercise exercise)
    {
        context.Add(exercise);
        await context.SaveChangesAsync();        
    }

    public async Task<List<Exercise>> Get()
    {
        return await context.Exercise.ToListAsync();
    }
}
