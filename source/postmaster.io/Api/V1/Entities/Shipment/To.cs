using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    /// <summary>
    /// To. Parent: <see cref="Shipment"/>
    /// </summary>
    public class To
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("phone_no")]
        public string PhoneNo { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("residential")]
        public bool Residential { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }
    }
}

