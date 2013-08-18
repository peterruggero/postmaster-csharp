using Newtonsoft.Json;
using Postmaster.io.Api.V1.Entities.Shipment;
using Postmaster.io.Communication.Api.V1.Entities;

namespace Postmaster.io.Api.V1.Handlers
{
    public class ResponseEntity
    {
        [JsonProperty]
        public Shipment Shipment { get; set; }

        [JsonProperty]
        public StatusCode StatusCode { get; set; }
    }
}
