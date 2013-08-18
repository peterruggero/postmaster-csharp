using System.Collections.Generic;
using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Tracking
{
    /// <summary>
    /// Tracking result; root entity.
    /// </summary>
    public class Tracking
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("history")]
        public List<History> History { get; set; }

        [JsonProperty("last_update")]
        public int LastUpdate { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }

        /// <summary>
        /// Convert string to Tracking object.
        /// </summary>
        /// <param name="data">Json string.</param>
        /// <returns>Tracking.</returns>
        public static Tracking Convert(string data)
        {
            return JsonConvert.DeserializeObject<Tracking>(data);
        }
    }
}