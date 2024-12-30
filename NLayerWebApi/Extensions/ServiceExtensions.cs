using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Constract;
using RepositoryLayer.EfCore;

namespace NLayerWebApi.Extensions
{
    public static  class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services,IConfiguration configuration)=>
        services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
        public static void ConfigureRepositoryManager(this IServiceCollection services)=>services.AddScoped<IRepositoryManager, RepositoryManager>();
        
    }
}
