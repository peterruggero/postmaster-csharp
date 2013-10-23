using System.Collections.Generic;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    /// <summary>
    /// ExternalPackage..
    /// </summary>
    public class ExternalPackage
    {
        #region Properties

        [JsonProperty("tracking_no")]
        public string TrackingNumber { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("sms", NullValueHandling = NullValueHandling.Ignore)]
        public string Sms { get; set; }

        [JsonProperty("events")]
        public List<string> Events { get; set; }

        [JsonIgnore]
        private const string Resource = "track";

        #endregion

        #region Utilities

        /// <summary>
        /// Monitor external package.
        /// </summary>
        /// <returns>ExternalPackageResponse or null.</returns>
        public static ExternalPackageResponse MonitorExternalPackage(ExternalPackage webhook)
        {
            // serialize shipment
            string postBody = JsonConvert.SerializeObject(webhook,
                new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Ignore});

            // https://api.postmaster.io/v1/track
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<ExternalPackageResponse>(response) : null;
        }

        #endregion
    }
}
