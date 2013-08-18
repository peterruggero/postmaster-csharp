using Newtonsoft.Json;

namespace Postmaster.io.Communication.Api.V1.Entities.Shipment
{
    /// <summary>
    /// Package. Parent: <see cref="Shipment"/> 
    /// </summary>
    public class Package
    {
        [JsonProperty("weight_units")]
        public string WeightUnits { get; set; }

        [JsonProperty("weight_units")]
        public double Weight { get; set; }

        [JsonProperty("weight_units")]
        public string Type { get; set; }

        [JsonProperty("weight_units")]
        public int Height { get; set; }

        [JsonProperty("weight_units")]
        public int Width { get; set; }

        [JsonProperty("weight_units")]
        public int Length { get; set; }

        [JsonProperty("weight_units")]
        public string LabelUrl { get; set; }

        [JsonProperty("dimention_units")]
        public string DimentionUnits { get; set; }
    }
}

