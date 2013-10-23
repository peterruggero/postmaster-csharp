using System;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Api.V1.Entities.Box
{
    /// <summary>
    /// Box.
    /// </summary>
    public class Box
    {
        #region Properties

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; set; }

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

        [JsonProperty("size_units", NullValueHandling = NullValueHandling.Ignore)]
        public string SizeUnits { get; set; }

        [JsonProperty("dimension_units", NullValueHandling = NullValueHandling.Ignore)]
        public string DimensionUnits { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public string Sku { get; set; }

        [JsonIgnore]
        private const string Resource = "packages";

        #endregion

        #region Functions

        /// <summary>
        /// Create this box.
        /// </summary>
        /// <returns>Box.</returns>
        public Box Create()
        {
            string postBody = JsonConvert.SerializeObject(this,
                new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Ignore});

            // https://api.postmaster.io/v1/packages
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<Box>(response) : null;
        }

        #endregion

        #region Utilities

        /// <summary>
        /// Create box.
        /// </summary>
        /// <param name="box">Box.</param>
        /// <returns>Box.</returns>
        public static Box Create(Box box)
        {
            string postBody = JsonConvert.SerializeObject(box,
                new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Ignore});

            // https://api.postmaster.io/v1/packages
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<Box>(response) : null;
        }


        #endregion
    }
}
