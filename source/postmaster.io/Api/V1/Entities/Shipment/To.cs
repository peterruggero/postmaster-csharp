using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    /// <summary>
    /// To. Parent: <see cref="Shipment"/>
    /// </summary>
    public class To
    {
        #region Properties

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }

        [JsonProperty("phone_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneNo { get; set; }

        [JsonProperty("line1", NullValueHandling = NullValueHandling.Ignore)]
        public string Line1 { get; set; }

        [JsonProperty("line2", NullValueHandling = NullValueHandling.Ignore)]
        public string Line2 { get; set; }

        [JsonProperty("line3", NullValueHandling = NullValueHandling.Ignore)]
        public string Line3 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public string Contact { get; set; }

        [JsonProperty("residential", NullValueHandling = NullValueHandling.Ignore)]
        public bool Residential { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        #endregion
    }
}

