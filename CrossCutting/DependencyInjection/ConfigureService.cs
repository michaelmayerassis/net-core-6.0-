using ApiData.Implementations;
using ApiData.Repositories;
using CustomDomain.Intefaces;
using CustomDomain.Intefaces.Services.User;
using CustomDomain.Repository;
using CustomService.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection service)
        {
            service.AddTransient<IUserService, UserService>();
            service.AddTransient<ILoginService, LoginService>();

            service.AddScoped(typeof(IApiRepository<>), typeof(BaseRepository<>));
            service.AddScoped<IUserRepository, UserImplementation>();
        }
    }
}
