using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Postmaster.io.Api.V1.Entities.Helper;
using Postmaster.io.Api.V1.Entities.Shipment;

namespace Postmaster.io.test
{
    [TestClass]
    public class UnitTestShipmentFunctionality
    {
        [TestMethod]
        public void GetShipments()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void CreateShipment()
        {
            // create Shipment object
            var shipment = new Shipment()
            {
                To = new To
                {
                    Contact = "Jesse James",
                    Line1 = "727 NW 23rd St",
                    City = "Oklahoma City",
                    State = UsState.Oklahoma,
                    ZipCode = "73103",
                    PhoneNo = "918-123-1234",
                    Residential = true
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
        public void VoidThisShipment()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void VoidShipment()
        {
            HttpStatusCode? result = Shipment.Void(5741031244955648);
            Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.OK, result.Value);
        }

        [TestMethod]
        public void RetrieveShipment()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void TrackThisShipmentById()
        {
            // create Shipment object
            var shipment = new Shipment()
            {
                To = new To
                {
                    Contact = "Jesse James",
                    Line1 = "727 NW 23rd St",
                    City = "Oklahoma City",
                    State = UsState.Oklahoma,
                    ZipCode = "73103",
                    PhoneNo = "918-123-1234",
                    Residential = true
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

            var result = response.Track();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TrackThisShipmentByReference()
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
            var result = Shipment.Track(6408984558829568);
            Assert.IsNotNull(result, "TrackShipmentById response returned null.");
        }

        [TestMethod]
        public void MapTrackShipmentByIdToObject()
        {
            throw new NotImplementedException();
        }
    }
}
