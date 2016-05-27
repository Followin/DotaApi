using System.Collections.Generic;
using System.Threading.Tasks;
using DotaApi.Domain.Models.Api;

namespace DotaApi.Dal.Interfaces.Repositories
{
    public interface IHeroesRepository
    {
        Task<IEnumerable<Hero>> GetAsync();
    }
}