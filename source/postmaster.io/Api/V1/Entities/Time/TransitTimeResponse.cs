using System.Collections.Generic;
using Newtonsoft.Json;

namespace Postmaster.io.Api.V1.Entities.Time
{
    /// <summary>
    /// TransitTimeResponse.
    /// </summary>
    public class TransitTimeResponse
    {
        #region Properties

        [JsonProperty("services")]
        public List<TransitTime> Services { get; set; }

        #endregion
    }
}