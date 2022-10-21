using ApiData.Implementations;
using ApiData.Repositories;
using CustomData.Context;
using CustomDomain.Intefaces;
using CustomDomain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CrossCutting.DependencyInjection
{
    public static class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddScoped(typeof(IApiRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            serviceCollection.AddDbContext<ApiContext>(
                options => options.UseMySql(connectionString,
                    new MySqlServerVersion(new Version(8, 0, 21))));
        }
    }
}
