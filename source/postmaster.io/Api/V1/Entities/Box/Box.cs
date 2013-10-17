using System;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

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

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        #endregion

        #region Functions

        public Box Create()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Utilities

        public static Box Create(Box box)
        {
            throw new NotImplementedException();
        }


        #endregion

    }
}
