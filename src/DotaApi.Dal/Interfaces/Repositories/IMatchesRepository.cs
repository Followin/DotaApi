using System.Collections.Generic;
using System.Threading.Tasks;
using DotaApi.Domain.Models.Api;

namespace DotaApi.Dal.Interfaces.Repositories
{
    public interface IMatchesRepository
    {
        Task<Match> Get(string id);
    }
}