using DecoratorDesignPattern.CoreL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DecoratorDesignPattern.DL;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

}