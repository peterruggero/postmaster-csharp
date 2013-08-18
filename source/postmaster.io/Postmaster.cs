using Postmaster.io.Api.V1.Entities.Shipment;
using Postmaster.io.Communication.Api.V1.Controllers;
using Postmaster.io.Communication.Api.V1.Utility;

namespace Postmaster.io
{
    /// <summary>
    /// Base Postmaster class
    /// </summary>
    public class Postmaster
    {
        private static Shipment _shipmentInstance;
        private static TrackingController _trackingInstance;
        private static Converter _converterInstnace;
        private static ValidationController _validationInstance;
        private static ModelController _modelInstance;

        /// <summary>
        /// Shipment singleton.
        /// </summary>
        /// <value>The shipment instance.</value>
        //public static ShipmentController Shipment 
        //{
        //    get 
        //    {
        //        return _shipmentInstance ?? (_shipmentInstance = new ShipmentController ());
        //    }
        //}

        //public static Shipment Shipment
        //{
        //    get
        //    {
        //        return _shipmentInstance = new Shipment();
        //    }
        //}

        /// <summary>
        /// Tracking singleton.
        /// </summary>
        /// <value>The tracking instance.</value>
        public static TrackingController Tracking
        {
            get
            {
                return _trackingInstance ?? (_trackingInstance = new TrackingController());
            }
        }

        /// <summary>
        /// Converter singleton.
        /// </summary>
        /// <value>The converter instance.</value>
        public static Converter Convert
        {
            get
            {
                return _converterInstnace ?? (_converterInstnace = new Converter());
            }
        }

        /// <summary>
        /// Validation singleton.
        /// </summary>
        /// <value>The validation instance.</value>
        public static ValidationController Validation
        {
            get
            {
                return _validationInstance ?? (_validationInstance = new ValidationController());
            }
        }

        /// <summary>
        /// Model singleton.
        /// </summary>
        /// <value>The model instance.</value>
        public static ModelController Model
        {
            get
            {
                return _modelInstance ?? (_modelInstance = new ModelController());
            }
        }
    }
}

