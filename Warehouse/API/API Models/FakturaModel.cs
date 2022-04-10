﻿using Newtonsoft.Json;
using System;

namespace Warehouse.API.API_Models
{
    public class FakturaModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("filial")]
        public string Filial { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}