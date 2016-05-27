using DotaApi.Dal.Interfaces.Repositories;
using DotaApi.Dal.Options;
using DotaApi.Dal.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotaApi.Dal.Profiles
{
    public class ServicesProfile
    {
        public static void Configure(IServiceCollection services)
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath("_configurations")
                .AddJsonFile("steamApp.json")
                .AddJsonFile("apiUrl.json");

            var config = configBuilder.Build();
            services.Configure<SteamApp>(config);
            services.Configure<ApiUrl>(config);

            services.AddTransient<IHeroesRepository, HeroesRepository>();
            services.AddTransient<IMatchesRepository, MatchesRepository>();
        }
    }
}
