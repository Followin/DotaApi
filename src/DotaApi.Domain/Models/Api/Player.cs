using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotaApi.Domain.Models.Api
{
    public class Player
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("player_slot")]
        public int PlayerSlot { get; set; }

        [JsonProperty("hero_id")]
        public int HeroId { get; set; }

        [JsonProperty("item_0")]
        public int Item0 { get; set; }

        [JsonProperty("item_1")]
        public int Item1 { get; set; }

        [JsonProperty("item_2")]
        public int Item2 { get; set; }

        [JsonProperty("item_3")]
        public int Item3 { get; set; }

        [JsonProperty("item_4")]
        public int Item4 { get; set; }

        [JsonProperty("item_5")]
        public int Item5 { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("leaver_status")]
        public int LeaverStatus { get; set; }

        [JsonProperty("gold")]
        public int Gold { get; set; }

        [JsonProperty("last_hits")]
        public int LastHits { get; set; }

        [JsonProperty("denies")]
        public int Denies { get; set; }

        [JsonProperty("gold_per_min")]
        public int GoldPerMin { get; set; }

        [JsonProperty("xp_per_min")]
        public int XpPerMin { get; set; }

        [JsonProperty("gold_spent")]
        public int GoldSpent { get; set; }

        [JsonProperty("hero_damage")]
        public int HeroDamage { get; set; }

        [JsonProperty("tower_damage")]
        public int TowerDamage { get; set; }

        [JsonProperty("hero_healing")]
        public int HeroHealing { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("ability_upgrades")]
        public IEnumerable<AbilityUpgrade> AbilityUpgrades { get; set; } 
    }
}