using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Time
{
    public class Time
    {
        [JsonProperty("delivery_timestamp")]
        public int DeliveryTimestamp { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }
    }
}
