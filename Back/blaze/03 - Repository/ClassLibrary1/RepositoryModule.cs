using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blaze.Repository;

public static class RepositoryModule
{
    public static IServiceCollection AddRepositoryModule(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("postgres")));

        services.AddScoped<IApostaRepository, ApostaRepository>();
        return services;
    }
}
