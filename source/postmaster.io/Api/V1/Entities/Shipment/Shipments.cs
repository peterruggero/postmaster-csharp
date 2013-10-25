using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Policy;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    /// <summary>
    /// Shipments.
    /// </summary>
    public class Shipments
    {
        #region Properties

        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public string Cursor { get; set; }

        [JsonProperty("previousCursor", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousCursor { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<Shipment> Results { get; set; }

        [JsonIgnore] private const string Resource = "shipments";

        #endregion

        #region Utilities

        /// <summary>
        /// Get all Shipments.
        /// </summary>
        /// <param name="limit">Result limit.</param>
        /// <param name="cursor">Cursor.</param>
        /// <param name="status">Status.</param>
        /// <returns>Shipments or null.</returns>
        public static Shipments All(int limit = 10, string cursor = null, string status = null)
        {
            // https://api.postmaster.io/v1/shipments
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            // query string construction
            NameValueCollection queryStrings = new NameValueCollection();
            queryStrings.Add("limit", limit.ToString());

            if (!string.IsNullOrEmpty(cursor))
            {
                queryStrings.Add("cursor", cursor);
            }

            if (!string.IsNullOrEmpty(status))
            {
                queryStrings.Add("status", status);
            }
            
            // get data
            string response = Request.Get(url, queryStrings:queryStrings);
            return response != null ? JsonConvert.DeserializeObject<Shipments>(response) : null;
        }

        #endregion
    }
}
