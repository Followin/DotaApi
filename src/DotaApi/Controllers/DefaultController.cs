using System.Linq;
using System.Threading.Tasks;
using DotaApi.Dal.Interfaces.Repositories;
using Microsoft.AspNet.Mvc;

namespace DotaApi.Controllers
{
    [Route("api")]
    public class DefaultController : Controller
    {
        private IHeroesRepository heroesRepository;
        private IMatchesRepository matchesRepository;

        public DefaultController(IHeroesRepository heroesRepository, IMatchesRepository matchesRepository)
        {
            this.heroesRepository = heroesRepository;
            this.matchesRepository = matchesRepository;
        }


        [Route("")]
        [HttpGet]
        [ResponseCache(Duration = 3600)]
        public async Task<IActionResult> Heroes()
        {
            return Ok(await heroesRepository.GetAsync());
        }

        [Route("match/{id}")]
        [HttpGet]
        [ResponseCache(Duration = 3600, Location = ResponseCacheLocation.Client)]
        public async Task<IActionResult> Match(string id)
        {
            var result = await matchesRepository.Get(id);
            return Json(result);
        }
    }
}
