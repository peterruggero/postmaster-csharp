using System.Collections.Generic;
using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Box
{
    /// <summary>
    /// FitResponseChild. Interior object.
    /// </summary>
    public class FitResponseBody
    {
        [JsonProperty("box", NullValueHandling = NullValueHandling.Ignore)]
        public Box Box { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; } 
    }
}
