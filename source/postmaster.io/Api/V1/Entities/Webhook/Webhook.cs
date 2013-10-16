using System.Collections.Generic;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Api.V1.Entities.Webhook
{
    /// <summary>
    /// Webhook.
    /// </summary>
    public class Webhook
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
        /// <returns>WebhookResponse or null.</returns>
        public static WebhookResponse MonitorExternalPackage(Webhook webhook)
        {
            // serialize shipment
            string postBody = JsonConvert.SerializeObject(webhook,
                new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Ignore});

            // https://api.postmaster.io/v1/track
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<WebhookResponse>(response) : null;
        }

        #endregion


    }
}
