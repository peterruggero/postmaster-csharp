using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    /// <summary>
    /// Package. Parent: <see cref="Shipment"/> 
    /// </summary>
    public class Package : BaseEntity
    {
        #region Declarations

        /// <summary>
        /// Package constructor.
        /// </summary>
        public Package() { }

        #endregion

        #region Properties

        [JsonProperty("weight_units", NullValueHandling = NullValueHandling.Ignore)]
        public string WeightUnits { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public double Weight { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int Height { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int Width { get; set; }

        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public int Length { get; set; }

        [JsonProperty("label_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelUrl { get; set; }

        [JsonProperty("dimension_units", NullValueHandling = NullValueHandling.Ignore)]
        public string DimensionUnits { get; set; }

        [JsonProperty("customs", NullValueHandling = NullValueHandling.Ignore)]
        public Customs Customs { get; set; }

        #endregion
    }
}

