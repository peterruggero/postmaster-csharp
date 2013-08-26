using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Postmaster.io.Api.V1.Entities.Helper;
using Postmaster.io.Api.V1.Entities.Shipment;

namespace Postmaster.io.test
{
    [TestClass]
    public class UnitTestShipmentFunctionality
    {
        [TestMethod]
        public void CreateShipment()
        {
            // create Shipment object
            var shipment = new Shipment
            {
                To = new To
                {
                    Contact = "Jesse James ",
                    City = "Oklahoma City",
                    State = "Oklahoma",
                    ZipCode = "73103",
                    PhoneNo = "123-123-1234"
                },
                Package = new Package
                {
                    Weight = 1.5,
                    Length = 10,
                    Width = 6,
                    Height = 8
                },
                Carrier = Carrier.Ups,
                Service = Service.TwoDay
            };

            // post object
            var response = shipment.Create();
            Assert.IsNotNull(response, "Shipment response returned null.");
        }

        [TestMethod]
        public void VoidShipment()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void RetrieveShipment()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TrackThisShipmentById()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TrackShipmentByReference()
        {
            var result = Shipment.Track("1ZW470V80310800043");
            Assert.IsNotNull(result, "TrackShipmentByReference response returned null.");
        }

        [TestMethod]
        public void MapTrackShipmentByReferenceToObject()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TrackShipmentById()
        {
            var result = Shipment.Track(3004);
            Assert.IsNotNull(result, "TrackShipmentById response returned null.");
        }

        [TestMethod]
        public void MapTrackShipmentByIdToObject()
        {
            throw new NotImplementedException();
        }
    }
}
