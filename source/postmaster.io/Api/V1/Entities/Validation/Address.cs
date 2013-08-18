using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Validation
{
    public class Address
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("commercial")]
        public bool Commercial { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}
