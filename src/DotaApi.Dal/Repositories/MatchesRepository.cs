using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DotaApi.Dal.Interfaces.Repositories;
using DotaApi.Dal.Options;
using DotaApi.Domain.Models.Api;
using Microsoft.Extensions.OptionsModel;
using Newtonsoft.Json.Linq;

namespace DotaApi.Dal.Repositories
{
    public class MatchesRepository : IMatchesRepository
    {
        private ApiUrl urls;
        private SteamApp steamApp;

        public MatchesRepository(IOptions<ApiUrl> urls, IOptions<SteamApp> steamApp)
        {
            this.urls = urls.Value;
            this.steamApp = steamApp.Value;
        }

        public async Task<Match> Get(string id)
        {
            var url = string.Join(
                "/",
                urls.BaseUrl,
                urls.Matches.Base + "_" + steamApp.AppId,
                urls.Matches.Details)
                      + "?key=" + steamApp.Key
                      + "&match_id=" + id;

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync(url);

                var match = JObject.Parse(response)["result"].ToObject<Match>();

                return match;
            }
        }
    }
}