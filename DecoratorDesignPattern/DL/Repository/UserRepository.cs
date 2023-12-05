using DecoratorDesignPattern.CoreL;
using DecoratorDesignPattern.CoreL.Entities;
using Microsoft.EntityFrameworkCore;


namespace DecoratorDesignPattern.DL.Repository;

public class UserRepository : IUserRepository
{
    private readonly Context _context;
    public UserRepository(Context context)
    {
        _context = context;
    }

    public async Task<User?> GetBy(int id)
    {
        var result = await _context.Users.FindAsync(id);
        return result;
    }


    public async Task<User?> GetBy(string email)
    {
        return await _context.Users.SingleOrDefaultAsync(c => c.Email == email);
    }

    public async Task<List<User>?> GetList()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task Create(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task Update(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }
    public async Task ChangeStatus(int userId,bool isActive)
    {
        var user = await _context.Users.SingleOrDefaultAsync(c => c.UserId == userId);
        if (user is null)
            throw new ArgumentNullException("مقدار وارد شده اشتباه است");
        user.IsActive=isActive;
        await _context.SaveChangesAsync();
    }
}