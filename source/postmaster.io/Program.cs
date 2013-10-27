using System.Collections.Generic;
using System.Diagnostics;
using Postmaster.io.Api.V1.Entities.Box;
using Postmaster.io.Api.V1.Entities.Helper;
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
            #region Create Shipment
            //Shipment shipment = new Shipment
            //{
            //    To = new To
            //    {
            //        Company = "ASLS",
            //        Contact = "Joe Smith",
            //        Line1 = "1110 Someplace Ave.",
            //        City = "Austin",
            //        State = "TX",
            //        ZipCode = "78704",
            //        PhoneNo = "5551234444"
            //    },
            //    Carrier = "ups",
            //    Service = "2day",
            //    Package = new Package
            //    {
            //        Weight = 1.5,
            //        Length = 10,
            //        Width = 6,
            //        Height = 8
            //    }
            //};

            //Shipment responseShipment = shipment.Create();
            //Debug.WriteLine(responseShipment.Id);

            //var trackResult = Shipment.Track("1ZE608Y30300032484");
            //Debug.WriteLine(trackResult.Status);

            //var voidStatus = responseShipment.Void();
            //Debug.WriteLine(voidStatus);

            //var trackingResults = Shipment.Track(4742228010336256);
            //var trackingResults = shipment.Track();

            //foreach (var result in trackingResults)
            //{
            //    Debug.WriteLine(result.Status);
            //}

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
            //                    {"country_of_origin", "US"}
            //                }
            //            }
            //        }
            //    }
            //};
            //intlShipment = intlShipment.Create();
            //Debug.WriteLine(intlShipment.Tracking[0] + ": " + intlShipment.To.City);

            #endregion

            #region Track

            //foreach (var trackingNumbers in intlShipment.Tracking)
            //{
            //    Debug.WriteLine(trackingNumbers);
            //}

            #endregion

            #region Get Shipments

            //var shipments = Shipments.All(10, status: "Voided");
            //if (shipment != null)
            //{

            //    foreach (var shipmentResult in shipments.Results)
            //    {
            //        Debug.WriteLine("Get shipments: " + shipmentResult.Id + "-" + shipmentResult.Status);
            //    }
            //    Debug.WriteLine("done...");
            //}

            #endregion

            #region Track

            ////var results = Shipment.Track(shipment.Id);
            ////if (results != null)
            ////{
            ////    foreach (var result1 in results)
            ////    {
            ////        Debug.WriteLine(result1.Status);
            ////    }
            ////}

            #endregion

            #region Track by Reference

            ////var result2 = Shipment.Track("1ZW470V80310800043");
            ////Debug.WriteLine(result2.Status);

            #endregion

            #region Monitor external package

            //ExternalPackage hook = new ExternalPackage
            //{
            //    TrackingNumber = "1ZW470V80310800043",
            //    Url = "sampleurl",
            //    Events = new List<string>
            //    {
            //        "Delivered",
            //        "Exception"
            //    }
            //};
            //var result3 = ExternalPackage.MonitorExternalPackage(hook);
            //Debug.WriteLine(result3.Event);

            #endregion

            #region Void Shipment

            ////var status = Shipment.Void(shipment.Id);
            ////Debug.WriteLine(status);

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

            ////TransitTime timeArgs = new TransitTime
            ////{
            ////    Carrier = "UPS",
            ////    Commercial = false,
            ////    FromZip = "74104",
            ////    ToZip = "74003",
            ////    Weight = 5.5
            ////};

            ////var times = TransitTime.GetTimes(timeArgs);
            ////foreach (var time in times)
            ////{
            ////    Debug.WriteLine(time.Service);
            ////    Debug.WriteLine(time.DeliveryTimestamp);
            ////}

            #endregion

            #region Get Rate

            //-d "from_country=US" \
            //  -d "to_country=KR" \
            //  -d "from_zip=78748" \
            //  -d "to_zip=683300" \
            //  -d "weight=1.0" \
            //  -d "service=INTL_PRIORITY"

            //Rate rateRequest = new Rate
            //{
            //    FromCountry = "US",
            //    ToCountry = "KR",
            //    FromZip = "78748",
            //    ToZip = "683300",
            //    Weight = 1.0,
            //    Service = "INTL_PRIORITY"
            //};

            //var rateResponse = Rate.GetRate(rateRequest);
            //Debug.WriteLine(rateResponse.Best);

            #endregion

            #region Create Box

            ////var box = new Box
            ////{
            ////    Width = 10,
            ////    Height = 12,
            ////    Length = 8,
            ////    Name = "My Fun Box"
            ////};

            ////// instance
            ////var boxResult = box.Create();
            ////Debug.WriteLine(boxResult.Id);

            ////// static
            ////boxResult = Box.Create(box);
            ////Debug.WriteLine(boxResult.Id);

            #endregion

            #region List Boxes

            ////var boxes = Boxes.All();
            ////foreach (var box1 in boxes.Results)
            ////{
            ////    Debug.WriteLine(box1.Id + " : " + box1.Name);
            ////}

            #endregion

            #region Fit Items in Box

            ////'{
            ////    "items":[{"width":2.2, "length":3, "height":1, "count":2}],
            ////    "packages":[
            ////    {"width":6, "length":6, "height":6, "sku":"123ABC"},
            ////    {"width":12, "length":12, "height":12, "sku":"456XYZ"}
            ////    ]
            ////    }'

            ////FitRequest fitRequest = new FitRequest
            ////{
            ////    Items = new List<Item>
            ////   {
            ////       new Item
            ////       {
            ////           Width = 2.2,
            ////           Length = 3,
            ////           Height = 1,
            ////           Count = 2
            ////       }
            ////   },
            ////    Packages = new List<Box>
            ////   {
            ////       new Box
            ////       {
            ////           Width = 6,
            ////           Length = 6,
            ////           Height = 6,
            ////           Sku = "123ABC"
            ////       },
            ////       new Box
            ////       {
            ////           Width = 12,
            ////           Length = 12,
            ////           Height = 12,
            ////           Sku = "456XYZ"
            ////       }
            ////   }
            ////};

            ////var fitResponse = fitRequest.Fit();
            ////foreach (var box2 in fitResponse.Boxes)
            ////{
            ////    Debug.WriteLine(box2.ImageUrl);
            ////}

            #endregion
        }
    }
}