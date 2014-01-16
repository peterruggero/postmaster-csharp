using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Rate
{
    /// <summary>
    /// RateResponseCarrier.
    /// </summary>
    public class RateResponseCarrier
    {
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        [JsonProperty("guaranteed_days", NullValueHandling = NullValueHandling.Ignore)]
        public string GuaranteedDays { get; set; }

        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        [JsonProperty("charge", NullValueHandling = NullValueHandling.Ignore)]
        public string Charge { get; set; }
    }
}
