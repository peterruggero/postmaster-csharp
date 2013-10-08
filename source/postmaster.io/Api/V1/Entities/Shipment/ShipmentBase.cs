using System.Net;
using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    public class ShipmentBase
    {
        #region Properties

        [JsonProperty]
        public Shipment Shipment { get; set; }

        [JsonProperty]
        public HttpStatusCode? StatusCode { get; set; }

        #endregion

        #region Utility

        /// <summary>
        /// Convert string to ResponseEntity object.
        /// </summary>
        /// <param name="data">Json string.</param>
        /// <returns>ResponseEntity.</returns>
        public static ShipmentBase Convert(string data)
        {
            return JsonConvert.DeserializeObject<ShipmentBase>(data);
        }

        #endregion
    }
}