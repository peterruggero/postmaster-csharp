using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Rate
{
    /// <summary>
    /// RateResponse.
    /// </summary>
    public class RateResponse
    {
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        [JsonProperty("charge", NullValueHandling = NullValueHandling.Ignore)]
        public string Charge { get; set; }

        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        [JsonProperty("best", NullValueHandling = NullValueHandling.Ignore)]
        public string Best { get; set; }

        [JsonProperty("ups", NullValueHandling = NullValueHandling.Ignore)]
        public RateResponseCarrier Ups { get; set; }

        [JsonProperty("fedex", NullValueHandling = NullValueHandling.Ignore)]
        public RateResponseCarrier FedEx { get; set; }

        [JsonProperty("usps", NullValueHandling = NullValueHandling.Ignore)]
        public RateResponseCarrier Usps { get; set; }

        [JsonProperty("lso", NullValueHandling = NullValueHandling.Ignore)]
        public RateResponseCarrier Lso { get; set; }

        [JsonProperty("canadapost", NullValueHandling = NullValueHandling.Ignore)]
        public RateResponseCarrier CanadaPost { get; set; }
    }
}