using Newtonsoft.Json;

namespace DotaApi.Domain.Models.Api
{
    public class AbilityUpgrade
    {
        [JsonProperty("ability")]
        public string Ability { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; } 
    }
}