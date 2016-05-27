using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DotaApi.Dal.Interfaces.Repositories;
using DotaApi.Dal.Options;
using DotaApi.Domain.Models.Api;
using Microsoft.Extensions.OptionsModel;
using Newtonsoft.Json.Linq;
using DotaApi.Utils.Extensions;

namespace DotaApi.Dal.Repositories
{
    public class HeroesRepository : IHeroesRepository
    {
        private SteamApp steamAppOptions;
        private ApiUrl urls;

        public HeroesRepository(IOptions<SteamApp> steamAppOptions, IOptions<ApiUrl> urls)
        {
            this.steamAppOptions = steamAppOptions.Value;
            this.urls = urls.Value;
        }

        public async Task<IEnumerable<Hero>> GetAsync()
        {
            var url = string.Join("/", urls.BaseUrl, urls.Economy.Base + "_" + steamAppOptions.AppId, urls.Economy.Heroes) + "?key=" + steamAppOptions.Key;

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);
                var heroes = JObject.Parse(response)["result"]["heroes"].ToObject<IEnumerable<Hero>>();
                heroes.ForEach(x =>
                {
                    x.Name = x.Name.Remove(0, 14);
                    var imageUrl = string.Join("/", urls.BaseImageUrl, urls.Images.Heroes, x.Name);
                    x.ImageUrl = imageUrl + "_" + ImageEndings.Large;
                });

                return heroes;
            }
        }
    }
}