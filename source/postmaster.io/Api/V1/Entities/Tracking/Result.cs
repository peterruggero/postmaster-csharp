using System.Collections.Generic;
using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Tracking
{
    /// <summary>
    /// Tracking result.
    /// </summary>
    public class Result
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
        public List<History> History { get; set; }

        [JsonProperty("signed_by", NullValueHandling = NullValueHandling.Ignore)]
        public string SignedBy { get; set; }

        [JsonProperty("last_update", NullValueHandling = NullValueHandling.Ignore)]
        public int LastUpdate { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int ErrorCode { get; set; }
    }
}
