using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    /// <summary>
    /// From. Parent: <see cref="Shipment"/>
    /// </summary>
    public class From : BaseEntity
    {
        #region Declarations

        /// <summary>
        /// From constructor.
        /// </summary>
        public From()
        {
            // set property defaults
            City = DefaultString;
            Country = DefaultString;
            Company = DefaultString;
            PhoneNo = DefaultString;
            Line1 = DefaultString;
            Line2 = DefaultString;
            Line3 = DefaultString;
            State = DefaultString;
            Contact = DefaultString;
            Residential = DefaultBool;
            ZipCode = DefaultString;
        }

        #endregion

        #region Properties

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

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("residential")]
        public bool Residential { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        #endregion
    }
}

