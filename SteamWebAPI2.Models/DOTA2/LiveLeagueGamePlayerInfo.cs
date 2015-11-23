﻿using Newtonsoft.Json;

namespace SteamWebAPI2.Models.DOTA2
{
    public class LiveLeagueGamePlayerInfo
    {
        [JsonProperty(PropertyName = "account_id")]
        public int AccountId { get; set; }

        public string Name { get; set; }

        [JsonProperty(PropertyName = "hero_id")]
        public int HeroId { get; set; }

        public int Team { get; set; }
    }
}