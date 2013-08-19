using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    /// <summary>
    /// Package. Parent: <see cref="Shipment"/> 
    /// </summary>
    public class Package
    {
        [JsonProperty("weight_units")]
        public string WeightUnits { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("label_url")]
        public string LabelUrl { get; set; }

        [JsonProperty("dimention_units")]
        public string DimentionUnits { get; set; }
    }
}

