using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Entities.Helper;

namespace Postmaster.io.Api.V1.Entities.Time
{
    public class TimeBase
    {

        #region Properties

        [JsonProperty("services")]
        public List<Service> Services { get; set; }

        #endregion

        #region Utility

        public static List<Service> GetTime()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
