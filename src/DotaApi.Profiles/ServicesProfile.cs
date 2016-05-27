using Microsoft.Extensions.DependencyInjection;
using DalProfile = DotaApi.Dal.Profiles.ServicesProfile;

namespace DotaApi.Profiles
{
    public class ServicesProfile
    {
        public static void Configure(IServiceCollection services)
        {
            DalProfile.Configure(services);
        } 
    }
}