using Postmaster.io.Api.V1.Handlers;

namespace Postmaster.io.Communication.Api.V1.Controllers
{
    /// <summary>
    /// Handles Tracking-related input.
    /// </summary>
    public class TrackingController
    {
        /// <summary>
        /// Tracks package by Shipment Id.
        /// </summary>
        /// <returns>Tracking information response.</returns>
        /// <param name="shipmentId">Shipment Id</param>
        public string Track(int shipmentId)
        {
            // https://api.postmaster.io/v1/shipments/1234/track
            string url = "{0}/{1}/{2}/{3}/track";
            url = string.Format(url, Config.BaseUri, Config.Version, ShipmentController.Resource, shipmentId);

            return Request.Get(url, null);
        }

        /// <summary>
        /// Tracks package by reference number.
        /// </summary>
        /// <returns>Tracking information response.</returns>
        /// <param name="reference">Reference number.</param>
        public string TrackByReference(string reference)
        {
            // https://api.postmaster.io/v1/track?tracking=1Z1896X70305267337
            string url = "{0}/{1}/track?tracking={2}";
            url = string.Format(url, Config.BaseUri, Config.Version, reference);

            return Request.Get(url, null);
        }
    }
}
