using System.Collections.Generic;
using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Box
{
    /// <summary>
    /// FitResponse.
    /// </summary>
    public class FitResponse
    {
        [JsonProperty("all_fit", NullValueHandling = NullValueHandling.Ignore)]
        public bool AllFit { get; set; }

        [JsonProperty("boxes", NullValueHandling = NullValueHandling.Ignore)]
        public List<FitResponseBody> Boxes { get; set; }

        [JsonProperty("leftovers", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Leftovers { get; set; } 
    }
}