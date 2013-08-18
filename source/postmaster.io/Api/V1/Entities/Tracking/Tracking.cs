using System.Collections.Generic;
using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Tracking
{
    public class Tracking
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("history")]
        public List<History> History { get; set; }

        [JsonProperty("last_update")]
        public int LastUpdate { get; set; }

        /// <summary>
        /// Convert string to Tracking object.
        /// </summary>
        /// <param name="data">Input string.</param>
        /// <returns>Tracking object.</returns>
        public static Tracking Convert(string data)
        {
            return JsonConvert.DeserializeObject<Tracking>(data);
        }
    }
}