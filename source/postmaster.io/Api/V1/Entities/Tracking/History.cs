using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Tracking
{
    public class History
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }
}
