using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Api.V1.Entities.Rate
{
    /// <summary>
    /// Rate.
    /// </summary>
    public class Rate
    {
        #region Properties

        [JsonProperty("from_zip", NullValueHandling = NullValueHandling.Ignore)]
        public string FromZip { get; set; }

        [JsonProperty("to_zip", NullValueHandling = NullValueHandling.Ignore)]
        public string ToZip { get; set; }

        [JsonProperty("from_country", NullValueHandling = NullValueHandling.Ignore)]
        public string FromCountry { get; set; }

        [JsonProperty("to_country", NullValueHandling = NullValueHandling.Ignore)]
        public string ToCountry { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public double Weight { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double Width { get; set; }

        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public double Length { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double Height { get; set; }

        [JsonProperty("carrier", NullValueHandling = NullValueHandling.Ignore)]
        public string Carrier { get; set; }

        [JsonProperty("commercial", NullValueHandling = NullValueHandling.Ignore)]
        public bool Commercial { get; set; }

        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        [JsonProperty("packaging", NullValueHandling = NullValueHandling.Ignore)]
        public string Packaging { get; set; }

        [JsonProperty("dimension_units", NullValueHandling = NullValueHandling.Ignore)]
        public string DimensionUnits { get; set; }

        [JsonIgnore] 
        private const string Resource = "rates";

        #endregion

        #region Functions

        /// <summary>
        /// Get Rate.
        /// </summary>
        /// <returns>Rate or null.</returns>
        public RateResponse GetRate()
        {
            // serialize shipment
            string postBody = JsonConvert.SerializeObject(this,
                new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });

            // https://api.postmaster.io/v1/rates
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<RateResponse>(response) : null;
        }

        #endregion

        #region Utilities

        /// <summary>
        /// Get Rate.
        /// </summary>
        /// <param name="rate">Rate.</param>
        /// <returns>Rate or null.</returns>
        public static RateResponse GetRate(Rate rate)
        {
            // serialize shipment
            string postBody = JsonConvert.SerializeObject(rate,
                new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Ignore});

            // https://api.postmaster.io/v1/rates
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<RateResponse>(response) : null;
        }

        #endregion
    }
}
