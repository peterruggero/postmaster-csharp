using Postmaster.io.Communication.Api.V1.Entities.Shipment;
using Postmaster.io.Communication.Api.V1.Handlers;
using Newtonsoft.Json;

namespace Postmaster.io.Communication.Api.V1.Controllers
{
    /// <summary>
    /// Handles Shipment-related input.
    /// </summary>
    public class ShipmentController
    {
        // instance variables
        public const string Resource = "shipments";

        /// <summary>
        /// Create the specified shipment.
        /// </summary>
        /// <param name="shipment">Shipment.</param>
        public object Create(Shipment shipment)
        {
            // serialize shipment
            string postBody = JsonConvert.SerializeObject(shipment);

            // https://api.postmaster.io/v1/shipments
            string url = "{0}/{1}/{3}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            return Request.Post(url, null, postBody);
        }
    }
}

