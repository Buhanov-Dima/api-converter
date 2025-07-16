using api_converter.Data.Scaffolded;
using Microsoft.EntityFrameworkCore;

namespace api_converter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Получаем строку подключения из appsettings.json
            var connectionString = builder.Configuration.GetConnectionString("Postgres");

            // Регистрируем контекст БД
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            var swaggerEnabled = builder.Configuration.GetValue<bool>("Swagger:Enabled");
            if (swaggerEnabled)
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapGet("/", context =>
            {
                context.Response.Redirect("/swagger", permanent: false);
                return Task.CompletedTask;
            });


            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
