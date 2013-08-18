using Newtonsoft.Json;
using Postmaster.io.Communication.Api.V1.Entities;
using Postmaster.io.Communication.Api.V1.Entities.Shipment;

namespace Postmaster.io.Communication.Api.V1.Handlers
{
    public class ResponseEntity
    {
        [JsonProperty]
        public Shipment Shipment { get; set; }

        [JsonProperty]
        public StatusCode StatusCode { get; set; }
    }
}
