using System.Collections.Generic;
using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    public class Customs
    {
        [JsonProperty("contents", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, object>> Contents { get; set; }

        //[JsonProperty("contents", NullValueHandling = NullValueHandling.Ignore)]
        //public Contents Contents { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }
}