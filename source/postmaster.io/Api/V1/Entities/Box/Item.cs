using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Box
{
    /// <summary>
    /// Item.
    /// </summary>
    public class Item
    {
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public double Width { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double Height { get; set; }

        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public double Length { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public double Weight { get; set; }

        [JsonProperty("weight_units", NullValueHandling = NullValueHandling.Ignore)]
        public string WeightUnits { get; set; }

        [JsonProperty("dimension_units", NullValueHandling = NullValueHandling.Ignore)]
        public string DimensionUnits { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public string Sku { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int Count { get; set; }
    }
}
