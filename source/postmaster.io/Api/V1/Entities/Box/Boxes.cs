﻿using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Api.V1.Entities.Box
{
    /// <summary>
    /// Boxes.
    /// </summary>
    public class Boxes
    {
        #region Properties

        [JsonProperty("cursor", NullValueHandling = NullValueHandling.Ignore)]
        public string Cursor { get; set; }

        [JsonProperty("previousCursor", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousCursor { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<Box> Results { get; set; }

        [JsonIgnore]
        private const string Resource = "packages";

        #endregion

        #region Utilities

        /// <summary>
        /// Get all Boxes.
        /// </summary>
        /// <param name="limit">Result limit.</param>
        /// <param name="cursor">Cursor.</param>
        /// <param name="status">Status.</param>
        /// <returns>Shipments.</returns>
        public static Boxes All(int limit = 10, string cursor = null, string status = null)
        {
            // https://api.postmaster.io/v1/boxes
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
            string response = Request.Get(url, queryStrings: queryStrings);
            return response != null ? JsonConvert.DeserializeObject<Boxes>(response) : null;
        }

        #endregion
    }
}