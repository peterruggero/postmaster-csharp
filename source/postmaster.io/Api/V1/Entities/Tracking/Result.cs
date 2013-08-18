using System.Collections.Generic;
using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Tracking
{
    /// <summary>
    /// Tracking result.
    /// </summary>
    public class Result
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("history")]
        public List<History> History { get; set; }

        [JsonProperty("signed_by")]
        public string SignedBy { get; set; }

        [JsonProperty("last_update")]
        public int LastUpdate { get; set; }
    }
}
