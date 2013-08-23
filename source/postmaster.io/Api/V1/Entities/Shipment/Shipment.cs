using System.Collections.Generic;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Handlers;
using Postmaster.io.Communication.Api.V1.Entities;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    /// <summary>
    /// Shipment; root entity.
    /// </summary>
    public class Shipment
    {
        #region Declarations

        /// <summary>
        /// Shipment constructor.
        /// </summary>
        public Shipment()
        {
            // initializers
            string defaultString = string.Empty;
            const int defaultInt = 0;
            List<string> defaultList = new List<string>();
            Dictionary<string, string> defaultDictionary = new Dictionary<string, string>();

            // set property defaults
            Carrier = defaultString;
            Cost = defaultInt;
            CreatedAt = defaultInt;
            Id = defaultInt;
            Options = defaultDictionary;
            PackageCount = defaultInt;
            PoNumber = defaultString;
            References = defaultList;
            Service = defaultString;
            Status = defaultString;
            Tracking = defaultString;
        }

        #endregion

        #region Properties

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tracking")]
        public string Tracking { get; set; }

        [JsonProperty("package_count")]
        public int PackageCount { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("to")]
        public To To { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("po_number")]
        public string PoNumber { get; set; }

        [JsonProperty("references")]
        public List<string> References { get; set; }

        [JsonProperty("options")]
        public Dictionary<string, string> Options { get; set; }
        
        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("from")]
        public From From { get; set; }

        [JsonProperty("package")]
        public Package Package { get; set; }

        [JsonProperty("packages")]
        public List<Package> Packages { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        public string ReferenceNo { get; set; }
        private const string Resource = "shipments";

        #endregion

        #region Functions

        /// <summary>
        /// Create this shipment.
        /// </summary>
        /// <returns>ResponseEntity.</returns>
        public ResponseEntity Create()
        {
            string postBody = JsonConvert.SerializeObject(this);

            // https://api.postmaster.io/v1/shipments
            string url = "{0}/{1}/{2}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            return Request.Post(url, postBody);
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
            string postBody = JsonConvert.SerializeObject(shipment);

            // https://api.postmaster.io/v1/shipments
            string url = "{0}/{1}/{3}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            var response = Request.Post(url, null, postBody);
            return response.StatusCode.Equals(StatusCode.PostSuccess) ? response.Shipment : null;
        }

        /// <summary>
        /// Track package by shipment id.
        /// </summary>
        /// <param name="shipmentId">Shipment id.</param>
        /// <returns>TO DO</returns>
        public static string Track(int shipmentId)
        {
            // https://api.postmaster.io/v1/shipments/1234/track
            string url = "{0}/{1}/{2}/{3}/track";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource, shipmentId);

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