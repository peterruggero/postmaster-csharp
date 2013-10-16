using System.Collections.Generic;
using System.Diagnostics;
using Postmaster.io.Api.V1.Entities.Shipment;

namespace Postmaster.io
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ////curl https://api.postmaster.io/v1/shipments \
            ////    -u tt_NDk4MDAxOkFyUUNScEtuRWMtNi1JcDJtWVR3SUh2Uks2aw: \
            ////    -d "to[company]=ASLS" \
            ////    -d "to[contact]=Joe Smith" \
            ////    -d "to[line1]=1110 Someplace Ave." \
            ////    -d "to[city]=Austin" \
            ////    -d "to[state]=TX" \
            ////    -d "to[zip_code]=78704" \
            ////    -d "to[phone_no]=5551234444" \
            ////    -d "carrier=ups" \
            ////    -d "service=2day" \
            ////    -d "package[weight]=1.5" \
            ////    -d "package[length]=10" \
            ////    -d "package[width]=6" \
            ////    -d "package[height]=8"

            // new shipment
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

            // new international shipment
            var intlShipment = new Shipment
            {
                To = new To
                {
                    Company = "Group SEB",
                    Contact = "Joe Smith",
                    Line1 = "Les 4 M - Chemin du Petit Bois",
                    Line2 = "BP 172",
                    City = "ECULLY CEDEX",
                    Country = "FR",
                    ZipCode = "69134",
                    PhoneNo = "9197207941",
                    Residential = true
                },
                Carrier = "FEDEX",
                Service = "INTL_PRIORITY",
                Package = new Package
                {
                    Weight = 2.2,
                    Length = 10,
                    Width = 6,
                    Height = 8,
                    Customs = new Customs
                    {
                        Type = "Other",
                        Description = "Some great stuff.",
                        Contents = new List<Dictionary<string, object>>
                        {
                            new Dictionary<string, object>
                            {
                                {"description", "A Bolt"},
                                {"value", 0.34},
                                {"quantity", 1},
                                {"weight", 0.5},
                                {"weight_units", "LB"},
                                {"country_of_origin", "FR"}

                            }
                        }
                    }
                }
            };
            intlShipment = intlShipment.Create();
            Debug.WriteLine(intlShipment.TrackingNo[0] + ": " + intlShipment.To.City);

            #region Track
            var results = Shipment.Track(4);
            foreach (var result in results)
            {
                Debug.WriteLine(result.Status);
            }
            #endregion

            #region Track By Reference
            //var result = Shipment.Track("1ZW470V80310800043");
            //Debug.WriteLine(result.Status);
            #endregion


            ////curl https://api.postmaster.io/v1/shipments \
            ////    -u 0b9a54438fba2dc0d39be8f7c6c71a58: \
            ////    -d "to[company]=Groupe SEB" \
            ////    -d "to[contact]=Joe Smith" \
            ////    -d "to[line1]=Les 4 M - Chemin du Petit Bois" \
            ////    -d "to[line2]=BP 172" \
            ////    -d "to[city]=ECULLY CEDEX" \
            ////    -d "to[country]=FR" \
            ////    -d "to[phone_no]=9197207941" \
            ////    -d "to[zip_code]=69134" \
            ////    -d "carrier=fedex" \
            ////    -d "service=INTL_PRIORITY" \
            ////    -d "package[weight]=2.2" \
            ////    -d "package[length]=10" \
            ////    -d "package[width]=6" \
            ////    -d "package[height]=8" \
            ////    -d "package[customs][type]=Other" \
            ////    -d "package[customs][description]=Some great stuff." \
            ////    -d "package[customs][contents][0][description]=A Bolt" \
            ////    -d "package[customs][contents][0][value]=0.34" \
            ////    -d "package[customs][contents][0][quantity]=1" \
            ////    -d "package[customs][contents][0][weight]=0.5" \
            ////    -d "package[customs][contents][0][country_of_origin]=FR"

            
        }
    }
}