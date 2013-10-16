using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Rate
{
    /// <summary>
    /// RateResponse.
    /// </summary>
    public class RateResponse
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("charge")]
        public string Charge { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }
    }
}
