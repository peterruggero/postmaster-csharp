using System.Diagnostics;
using Postmaster.io.Api.V1.Entities.Shipment;
using Postmaster.io.Api.V1.Entities.Time;
using Postmaster.io.Api.V1.Entities.Validation;

namespace Postmaster.io
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Create shipments
            //// new shipment
            //var shipment = new Shipment
            //{
            //    To = new To
            //    {
            //        Company = "ASLS",
            //        Contact = "Joe Smith",
            //        Line1 = "1110 Someplace Ave.",
            //        City = "Austin",
            //        State = "TX",
            //        ZipCode = "78704",
            //        PhoneNo = "5551234444",
            //        Residential = true
            //    },
            //    Carrier = "UPS",
            //    Service = "2DAY",
            //    Package = new Package
            //    {
            //        Weight = 1.5,
            //        Length = 10,
            //        Width = 6,
            //        Height = 8
            //    },
            //};
            //shipment = shipment.Create();
            //Debug.WriteLine(shipment.To.City);
            //shipment = Shipment.Create(shipment);
            //Debug.WriteLine(shipment.From.City);

            // new international shipment
            //var intlShipment = new Shipment
            //{
            //    To = new To
            //    {
            //        Company = "Group SEB",
            //        Contact = "Joe Smith",
            //        Line1 = "Les 4 M - Chemin du Petit Bois",
            //        Line2 = "BP 172",
            //        City = "ECULLY CEDEX",
            //        Country = "FR",
            //        ZipCode = "69134",
            //        PhoneNo = "9197207941",
            //        Residential = true
            //    },
            //    Carrier = "FEDEX",
            //    Service = "INTL_PRIORITY",
            //    Package = new Package
            //    {
            //        Weight = 2.2,
            //        Length = 10,
            //        Width = 6,
            //        Height = 8,
            //        Customs = new Customs
            //        {
            //            Type = "Other",
            //            Description = "Some great stuff.",
            //            Contents = new List<Dictionary<string, object>>
            //            {
            //                new Dictionary<string, object>
            //                {
            //                    {"description", "A Bolt"},
            //                    {"value", 0.34},
            //                    {"quantity", 1},
            //                    {"weight", 0.5},
            //                    {"weight_units", "LB"},
            //                    {"country_of_origin", "FR"}

            //                }
            //            }
            //        }
            //    }
            //};
            //intlShipment = intlShipment.Create();
            //Debug.WriteLine(intlShipment.TrackingNo[0] + ": " + intlShipment.To.City);

            #endregion

            #region Track

            //var results = Shipment.Track(4);
            //foreach (var result in results)
            //{
            //    Debug.WriteLine(result.Status);
            //}

            #endregion

            #region Track by Reference

            //var result = Shipment.Track("1ZW470V80310800043");
            //Debug.WriteLine(result.Status);

            #endregion

            #region Validate address

            //Address address = new Address
            //{
            //    Company = "ACME",
            //    Contact = "Joe Smith",
            //    Line1 = "100 Congress Ave.",
            //    City = "Austin",
            //    State = "TX",
            //    ZipCode = "78701"
            //};
            //var result = address.Validate();
            //Debug.WriteLine(result.Status);

            #endregion

            #region Get Transit Times

            //TransitTime timeArgs = new TransitTime
            //{
            //    Carrier = "USPS",
            //    Commercial = false,
            //    FromZip = "74104",
            //    ToZip = "74003",
            //    Weight = 5.5
            //};

            //var times = TransitTime.GetTimes(timeArgs);
            //foreach (var time in times)
            //{
            //    Debug.WriteLine(time.Service);
            //    Debug.WriteLine(time.DeliveryTimestamp);
            //}

            #endregion
        }
    }
}