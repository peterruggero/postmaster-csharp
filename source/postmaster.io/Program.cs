using System.Collections.Generic;
using System.Diagnostics;
using Postmaster.io.Api.V1.Entities.Box;
using Postmaster.io.Api.V1.Entities.Rate;
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
            // new shipment
            var shipment = new Shipment
            {
                To = new To
                {
                    Company = "ASLS",
                    Contact = "Joe Smith",
                    Line1 = "1110 Someplace Ave.",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78704",
                    PhoneNo = "5551234444",
                    Residential = true
                },
                Carrier = "ups",
                Service = "2day",
                Package = new Package
                {
                    Weight = 1.5,
                    Length = 10,
                    Width = 6,
                    Height = 8
                },
            };
            shipment = shipment.Create();
            Debug.WriteLine("Shipment created: " + shipment.Id);

            //Debug.WriteLine(shipment.To.City);
            //shipment = Shipment.Create(shipment);
            //Debug.WriteLine(shipment.From.City);

            //// new international shipment
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
            //            Comments = "Some great stuff.",
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
            //Debug.WriteLine(intlShipment.Tracking[0] + ": " + intlShipment.To.City);

            #endregion

            #region Get Shipments

            var shipments = Shipments.All(10, status: "Voided");
            if (shipment != null)
            {

                foreach (var shipmentResult in shipments.Results)
                {
                    Debug.WriteLine("Get shipments: " + shipmentResult.Id + "-" + shipmentResult.Status);
                }
                Debug.WriteLine("done...");
            }

            #endregion

            #region Track

            var results = Shipment.Track(shipment.Id);
            if (results != null)
            {
                foreach (var result1 in results)
                {
                    Debug.WriteLine(result1.Status);
                }
            }

            #endregion

            #region Track by Reference

            var result2 = Shipment.Track("1ZW470V80310800043");
            Debug.WriteLine(result2.Status);

            #endregion

            #region Monitor external package

            ExternalPackage hook = new ExternalPackage
            {
                TrackingNumber = "1ZW470V80310800043",
                Url = "sampleurl",
                Events = new List<string>
                {
                    "Delivered",
                    "Exception"
                }
            };
            var result3 = ExternalPackage.MonitorExternalPackage(hook);
            Debug.WriteLine(result3.Event);

            #endregion

            #region Void Shipment

            //var status = Shipment.Void(shipment.Id);
            //Debug.WriteLine(status);

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

            #region Get Rate

            //curl https://api.postmaster.io/v1/rates \
            //    -u 0b9a54438fba2dc0d39be8f7c6c71a58: \
            //    -d "from_zip=28771" \
            //    -d "to_zip=78704" \
            //    -d "weight=1.0" \
            //    -d "carrier=ups"

            //Rate rateArgs = new Rate
            //{
            //    FromZip = "28771",
            //    ToZip = "78704",
            //    Weight = 1.0,
            //    Carrier = "ups"
            //};

            //var result = Rate.GetRate(rateArgs);
            //Debug.WriteLine(result.Charge);
            //Debug.WriteLine(rateArgs.GetRate().Charge);

            #endregion

            #region Create Box

            //var box = new Box
            //{
            //    Width = 10,
            //    Height = 12,
            //    Length = 8,
            //    Name = "My Fun Box"
            //};

            //// instance
            //var boxResult = box.Create();
            //Debug.WriteLine(boxResult.Id);

            //// static
            //boxResult = Box.Create(box);
            //Debug.WriteLine(boxResult.Id);

            #endregion

            #region List Boxes

            //var boxes = Boxes.All();
            //foreach (var box in boxes.Results)
            //{
            //    Debug.WriteLine(box.Id + " : " + box.Name);
            //}

            #endregion

            #region Fit Items in Box

            //'{
            //    "items":[{"width":2.2, "length":3, "height":1, "count":2}],
            //    "packages":[
            //    {"width":6, "length":6, "height":6, "sku":"123ABC"},
            //    {"width":12, "length":12, "height":12, "sku":"456XYZ"}
            //    ]
            //    }'

            //FitRequest fitRequest = new FitRequest
            //{
            //   Items = new List<Item>
            //   {
            //       new Item
            //       {
            //           Width = 2.2,
            //           Length = 3,
            //           Height = 1,
            //           Count = 2
            //       }
            //   },
            //   Packages = new List<Box>
            //   {
            //       new Box
            //       {
            //           Width = 6,
            //           Length = 6,
            //           Height = 6,
            //           Sku = "123ABC"
            //       },
            //       new Box
            //       {
            //           Width = 12,
            //           Length = 12,
            //           Height = 12,
            //           Sku = "456XYZ"
            //       }
            //   }
            //};

            //var fitResponse = fitRequest.Fit();
            //foreach (var box in fitResponse.Boxes)
            //{
            //    Debug.WriteLine(box.ImageUrl);
            //}

            #endregion
        }
    }
}