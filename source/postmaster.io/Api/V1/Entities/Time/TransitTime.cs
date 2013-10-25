using System.Collections.Generic;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Entities.Helper;
using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Api.V1.Entities.Time
{
    /// <summary>
    /// TransitTime.
    /// </summary>
    public class TransitTime
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

        [JsonProperty("carrier", NullValueHandling = NullValueHandling.Ignore)]
        public string Carrier { get; set; }

        [JsonProperty("commercial", NullValueHandling = NullValueHandling.Ignore)]
        public bool Commercial { get; set; }

        [JsonProperty("delivery_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public int DeliveryTimestamp { get; set; }

        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        [JsonIgnore]
        private const string Resource = "times";

        #endregion

        #region Functions

        /// <summary>
        /// Get transit times.
        /// </summary>
        /// <returns>TimeResponse or null.</returns>
        public List<TransitTime> GetTimes()
        {
            // serialize shipment
            string postBody = JsonConvert.SerializeObject(this,
                new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });

            // https://api.postmaster.io/v1/times
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<TransitTimeResponse>(response).Services : null;
        }

        #endregion

        #region Utilities

        /// <summary>
        /// Get transit times.
        /// </summary>
        /// <param name="transitTime">TransitTime.</param>
        /// <returns>TimeResponse or null.</returns>
        public static List<TransitTime> GetTimes(TransitTime transitTime)
        {
            // serialize shipment
            string postBody = JsonConvert.SerializeObject(transitTime,
                new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Ignore});

            // https://api.postmaster.io/v1/times
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<TransitTimeResponse>(response).Services : null;
        }

        #endregion
    }
}
