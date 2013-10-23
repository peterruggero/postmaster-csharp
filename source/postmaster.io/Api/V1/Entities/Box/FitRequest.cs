using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Api.V1.Entities.Box
{
    /// <summary>
    /// Fit.
    /// </summary>
    public class FitRequest
    {
        #region Properties

        [JsonProperty("packages")]
        public List<Box> Packages { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; }
        
        [JsonProperty("package_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int PackageLimit { get; set; }

        [JsonIgnore] 
        public const string Resource = "packages/fit";

        #endregion



        /// <summary>
        /// Fit items in box with specified properties.
        /// </summary>
        /// <returns>FitResponse or null.</returns>
        public FitResponse Fit()
        {
            string postBody = JsonConvert.SerializeObject(this,
                new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Ignore});

            // https://api.postmaster.io/v1/packages/fit
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<FitResponse>(response) : null;
        }


        /// <summary>
        /// Fit items in box with specified properties.
        /// </summary>
        /// <param name="fitRequest">FitRequest.</param>
        /// <returns>FitResponse or null.</returns>
        public static FitResponse Fit(FitRequest fitRequest)
        {
            string postBody = JsonConvert.SerializeObject(fitRequest,
                new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Ignore});

            // https://api.postmaster.io/v1/packages/fit
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<FitResponse>(response) : null;
        }
    }
}
