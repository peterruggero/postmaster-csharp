using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;
using Postmaster.io.Api.V1.Resources;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    /// <summary>
    /// Shipment; root entity.
    /// </summary>
    public class Shipment : BaseEntity
    {
        #region Properties

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("tracking", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tracking { get; set; }

        [JsonProperty("prepaid", NullValueHandling = NullValueHandling.Ignore)]
        public bool Prepaid { get; set; }

        [JsonProperty("package_count", NullValueHandling = NullValueHandling.Ignore)]
        public int PackageCount { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public int CreatedAt { get; set; }

        [JsonProperty("to")]
        public To To { get; set; }

        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public int Cost { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("po_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PoNumber { get; set; }

        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> References { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Options { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public From From { get; set; }

        [JsonProperty("package")]
        public Package Package { get; set; }

        [JsonProperty("packages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Package> Packages { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; set; }

        [JsonIgnore]
        public string ReferenceNo { get; set; }

        [JsonIgnore]
        private const string Resource = "shipments";

        #endregion

        #region Functions

        /// <summary>
        /// Create this shipment.
        /// </summary>
        /// <returns>ResponseEntity.</returns>
        public Shipment Create()
        {
            string postBody = JsonConvert.SerializeObject(this);

            // https://api.postmaster.io/v1/shipments
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, postBody);

            return response != null ? JsonConvert.DeserializeObject<Shipment>(response) : null;
        }

        /// <summary>
        /// Void this shipment.
        /// </summary>
        /// <returns>ResponseEntity.</returns>
        public HttpStatusCode? Void()
        {
            // https://api.postmaster.io/v1/shipments/:id/void
            string url = "{0}/{1}/{2}/{3}/void";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource, this.Id);

            return Request.Delete(url);
        }

        /// <summary>
        /// Track this shipment.
        /// </summary>
        /// <returns>TO DO</returns>
        public string Track()
        {
            // https://api.postmaster.io/v1/shipments/1234/track
            string url = "{0}/{1}/{2}/{3}/track";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource, Id);

            return Request.Get(url, null);
        }

        /// <summary>
        /// Validate this address.
        /// </summary>
        /// <returns>Bool.</returns>
        public bool ValidateAddress()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Utilities

        /// <summary>
        /// Convert string to Tracking object.
        /// </summary>
        /// <param name="data">Json string.</param>
        /// <returns>Tracking.</returns>
        public static Shipment Convert(string data)
        {
            return JsonConvert.DeserializeObject<Shipment>(data);
        }

        /// <summary>
        /// Create shipment.
        /// </summary>
        /// <param name="shipment">Shipment.</param>
        /// <returns>Shipment response or null.</returns>
        public static Shipment Create(Shipment shipment)
        {
            // serialize shipment
            string postBody = JsonConvert.SerializeObject(shipment,
                new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Ignore});

            // https://api.postmaster.io/v1/shipments
            string url = "{0}/{1}/{3}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            string response = Request.Post(url, null, postBody);

            return response != null ? JsonConvert.DeserializeObject<Shipment>(response) : null;
        }

        /// <summary>
        /// Void shipment by Id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>HttpStatusCode?.</returns>
        public static HttpStatusCode? Void(long id)
        {
            // https://api.postmaster.io/v1/shipments/:id/void
            string url = "{0}/{1}/{2}/{3}/void";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource, id);

            return Request.Delete(url);
        }

        /// <summary>
        /// Get Shipment by Id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>Shipment.</returns>
        public static Shipment Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all Shipments.
        /// </summary>
        /// <param name="limit">Result limit.</param>
        /// <returns>Shipment collection.</returns>
        public static List<Shipment> GetAll(int limit)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Track package by shipment Id.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <returns>TO DO</returns>
        public static string Track(long id)
        {
            // https://api.postmaster.io/v1/shipments/1234/track
            string url = "{0}/{1}/{2}/{3}/track";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource, id);

            return Request.Get(url, null);
        }

        /// <summary>
        /// Track package by reference number.
        /// </summary>
        /// <param name="referenceNo">Reference number.</param>
        /// <returns>TO DO</returns>
        public static string Track(string referenceNo)
        {
            // https://api.postmaster.io/v1/track?tracking=1Z1896X70305267337
            string url = "{0}/{1}/track?tracking={2}";
            url = string.Format(url, Config.BaseUri, Config.Version, referenceNo);

            return Request.Get(url, null);
        }

        #endregion
    }
}