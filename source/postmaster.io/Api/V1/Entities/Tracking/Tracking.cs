using System.Collections.Generic;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Api.V1.Entities.Tracking
{
    /// <summary>
    /// Utility class for tracking shipments.
    /// </summary>
    public class Tracking
    {
        [JsonProperty("results")]
        public List<Result> Results { get; set; }

        [JsonIgnore]
        private const string Resource = "shipments";

        /// <summary>
        /// Track Shipment by Id.
        /// </summary>
        /// <param name="id">Shipment Id.</param>
        /// <returns>Result collection.</returns>
        public static List<Result> Track(long id)
        {
            // https://api.postmaster.io/v1/shipments/1234/track
            string url = "{0}/{1}/{2}/{3}/track";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource, id);

            string response = Request.Get(url, null);

            return response != null ? JsonConvert.DeserializeObject<List<Result>>(response) : null;
        }

        /// <summary>
        /// Track Shipment by reference number.
        /// </summary>
        /// <param name="referenceNumber">Reference number.</param>
        /// <returns>TO DO</returns>
        public static Result Track(string referenceNumber)
        {
            // https://api.postmaster.io/v1/shipments/1234/track
            string url = "{0}/{1}/{2}/{3}/track";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource, referenceNumber);

            string response = Request.Get(url, null);

            return response != null ? JsonConvert.DeserializeObject<Result>(response) : null;
        }
    }
}