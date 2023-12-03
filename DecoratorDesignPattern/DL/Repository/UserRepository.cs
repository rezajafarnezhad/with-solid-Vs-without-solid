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
}