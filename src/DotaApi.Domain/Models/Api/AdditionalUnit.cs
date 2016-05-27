﻿using Newtonsoft.Json;

namespace DotaApi.Domain.Models.Api
{
    public class AdditionalUnit
    {
        [JsonProperty("name")]
        public string Name { get; set; }

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
    }
}