﻿using Newtonsoft.Json;

namespace SteamWebAPI2.Models.DOTA2
{
    public class LiveLeagueGamePick
    {
        [JsonProperty(PropertyName = "hero_id")]
        public int HeroId { get; set; }
    }
}