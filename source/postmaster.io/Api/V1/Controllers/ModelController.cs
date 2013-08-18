using Postmaster.io.Api.V1.Entities.Helper;
using Postmaster.io.Api.V1.Entities.Shipment;
using Postmaster.io.Api.V1.Entities.Validation;

namespace Postmaster.io.Communication.Api.V1.Controllers
{
    public class ModelController
    {
        public static Shipment Shipment { get; set; }
        public static Carrier Carrier { get; set; }
        public static Address Address { get; set; }
    }
}
