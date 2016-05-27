using Newtonsoft.Json;

namespace DotaApi.Domain.Models.Api
{
    public class PickBan
    {
        [JsonProperty("is_pick")]
        public bool IsPick { get; set; }

        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        [JsonProperty("team")]
        public int Team { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; } 
    }
}