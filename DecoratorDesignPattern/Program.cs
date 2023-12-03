
using DecoratorDesignPattern.CoreL;
using DecoratorDesignPattern.DL;
using DecoratorDesignPattern.DL.Repository;
using Microsoft.EntityFrameworkCore;


namespace DecoratorDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<Context>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("connection"));
            });


            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.Decorate<IUserRepository, CachingUserRepository>();


            builder.Services.AddMemoryCache();
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}