using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class UserRepository(ApplicationDbContext context)
{
    public async Task Create(User user)
    {
        await context.User.AddAsync(user);
        await context.SaveChangesAsync();
    }

    public async Task Update(User user)
    {
        context.User.Update(user);
        await context.SaveChangesAsync();
    }
}
