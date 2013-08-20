using Newtonsoft.Json;
using Postmaster.io.Communication.Api.V1.Entities;

namespace Postmaster.io.Api.V1.Entities
{
    public class ResponseEntity
    {
        #region Properties

        [JsonProperty]
        public Shipment.Shipment Shipment { get; set; }

        [JsonProperty]
        public StatusCode StatusCode { get; set; }

        #endregion

        #region Utility

        /// <summary>
        /// Convert string to ResponseEntity object.
        /// </summary>
        /// <param name="data">Json string.</param>
        /// <returns>ResponseEntity.</returns>
        public static ResponseEntity Convert(string data)
        {
            return JsonConvert.DeserializeObject<ResponseEntity>(data);
        }

        #endregion
    }
}