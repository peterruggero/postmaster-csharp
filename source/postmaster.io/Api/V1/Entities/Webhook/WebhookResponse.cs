using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Webhook
{
    /// <summary>
    /// WebhookResponse.
    /// </summary>
    public class WebhookResponse
    {
        [JsonProperty("tracking_no")]
        public string TrackingNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }
    }
}
