using Newtonsoft.Json;
using Postmaster.io.Api.V1.Resources;

namespace Postmaster.io.Api.V1.Entities.Shipment
{
    public class ResponseEntity
    {
        #region Properties

        [JsonProperty]
        public Shipment Shipment { get; set; }

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