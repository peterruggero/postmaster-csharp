using Newtonsoft.Json;
using Postmaster.io.Communication.Api.V1.Entities.Validation;
using Postmaster.io.Communication.Api.V1.Handlers;

namespace Postmaster.io.Communication.Api.V1.Controllers
{
    /// <summary>
    /// Handles Validation-related input.
    /// </summary>
    public class ValidationController
    {
        // instance variables
        public const string Resource = "validate";

        /// <summary>
        /// Validate the input address
        /// </summary>
        /// <param name="address">Address.</param>
        public object ValidateAddress(Address address)
        {
            // serialize address
            string postBody = JsonConvert.SerializeObject(address);

            // https://api.postmaster.io/v1/validate
            string url = "{0}/{1}/{3}";
            url = string.Format(url, Config.BaseUri, Config.Version, Resource);

            return Request.Post(url, null, postBody);
        }
    }
}
