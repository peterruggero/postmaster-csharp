using System;
using Postmaster.io.Communication.Api.V1.Entities.Helper;
using Postmaster.io.Communication.Api.V1.Entities.Shipment;

namespace Postmaster.io
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string trackResponse1 = Postmaster.Shipment.Track(1124);
            string trackResponse2 = Postmaster.Tracking.TrackByReference("1ZW470V80310800043");
            Console.WriteLine(trackResponse2);

            Shipment shipment = new Shipment();

            shipment.Carrier = Carrier.FedEx;

            // var tObject = Postmaster.Convert(Tracking, trackResponse2);

            //Console.WriteLine("Status: " + tObject.Status);

        }
    }
}