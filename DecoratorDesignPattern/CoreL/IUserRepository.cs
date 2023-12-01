using DecoratorDesignPattern.CoreL.Entities;

namespace DecoratorDesignPattern.CoreL;

public interface IUserRepository
{
    Task<User?> GetBy(int id);
    Task<User?> GetBy(string email);
    Task<List<User>?> GetList();
}

