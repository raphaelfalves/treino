using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class TrainingRepository(ApplicationDbContext context)
{
    public async Task Create(Training Training)
    {
        context.Add(Training);
        await context.SaveChangesAsync();        
    }

    public async Task<List<Training>> Get()
    {
        return await context.Training
            .Include(x => x.ExerciseTraining)
            .ThenInclude(x => x.Sets)
            .ToListAsync();
    }
}
