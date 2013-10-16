using System.Collections.Generic;
using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Validation
{
    /// <summary>
    /// ValidationResponse.
    /// </summary>
    public class ValidationResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("addresses")]
        public List<Address> Addresses { get; set; }
    }
}