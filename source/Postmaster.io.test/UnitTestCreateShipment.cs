using Microsoft.VisualStudio.TestTools.UnitTesting;
using Postmaster.io.Api.V1.Entities.Helper;
using Postmaster.io.Api.V1.Entities.Shipment;

namespace Postmaster.io.test
{
    [TestClass]
    public class UnitTestCreateShipment
    {
        [TestMethod]
        public void CreateShipment()
        {
            // create Shipment object
            var shipment = new Shipment
            {
                To = new To
                {
                    Contact = "John Smith",
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

            // read response
        }
    }
}
