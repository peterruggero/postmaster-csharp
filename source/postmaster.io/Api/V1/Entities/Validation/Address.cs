using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Api.V1.Entities.Validation
{
    /// <summary>
    /// Address.
    /// </summary>
    public class Address
    {
        #region Properties

        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public string Contact { get; set; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }

        [JsonProperty("line1", NullValueHandling = NullValueHandling.Ignore)]
        public string Line1 { get; set; }

        [JsonProperty("line2", NullValueHandling = NullValueHandling.Ignore)]
        public string Line2 { get; set; }

        [JsonProperty("line3", NullValueHandling = NullValueHandling.Ignore)]
        public string Line3 { get; set; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("zip_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ZipCode { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonIgnore]
        private const string Resource = "validate";

        #endregion

        #region Functions

        /// <summary>
        /// Validate this address.
        /// </summary>
        /// <returns>ValidationResponse or null.</returns>
        public ValidationResponse Validate()
        {
            // serialize shipment
            string postBody = JsonConvert.SerializeObject(this,
                new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });

            // https://api.postmaster.io/v1/validate
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<ValidationResponse>(response) : null;
        }

        /// <summary>
        /// Validate address.
        /// </summary>
        /// <returns>ValidationResponse or null.</returns>
        public static ValidationResponse Validate(Address address)
        {
            // serialize shipment
            string postBody = JsonConvert.SerializeObject(address,
                new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });

            // https://api.postmaster.io/v1/validate
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<ValidationResponse>(response) : null;
        }

        #endregion
    }
}
