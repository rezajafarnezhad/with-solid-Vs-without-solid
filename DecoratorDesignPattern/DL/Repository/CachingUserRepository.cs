using System.Runtime.CompilerServices;
using DecoratorDesignPattern.CoreL;
using DecoratorDesignPattern.CoreL.Entities;
using Microsoft.Extensions.Caching.Memory;

namespace DecoratorDesignPattern.DL.Repository;

public class CachingUserRepository : IUserRepository
{
    private static readonly TimeSpan CacheTime = TimeSpan.FromMinutes(2);
    private readonly IUserRepository _userRepository;
    private readonly IMemoryCache _cache;
    public CachingUserRepository(IUserRepository userRepository, IMemoryCache cache)
    {
        _userRepository = userRepository;
        _cache = cache;
    }

    public Task<User?> GetBy(int id)
    {
        Console.WriteLine("<<<<<<<Id Caching>>>>>>>");
        return _cache.GetOrCreateAsync(
        $"User-{id}",
        cacheEntry =>
        {
            cacheEntry.SetAbsoluteExpiration(CacheTime);
            return _userRepository.GetBy(id);
        });
    }

    public Task<User?> GetBy(string email)
    {
        Console.WriteLine("<<<<<<<Email Caching>>>>>>>>");
        return _cache.GetOrCreateAsync(
            $"User-{email}",
            cacheEntry =>
            {
                cacheEntry.SetAbsoluteExpiration(CacheTime); 
                return _userRepository.GetBy(email);

            });
    }

    public Task<List<User>?> GetList()
    {
        return _cache.GetOrCreateAsync(
            $"Users-a",
            cacheEntry =>
            {
                cacheEntry.SetAbsoluteExpiration(CacheTime);
                return _userRepository.GetList();

            });
    }

    public Task Create(User user)
    {
       return _userRepository.Create(user);
    }

    public Task Update(User user)
    {
        return _userRepository.Update(user);
    }

    public Task ChangeStatus(int userId, bool isActive)
    {
        return _userRepository.ChangeStatus(userId, isActive);
    }
}