using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Postmaster.io.Api.V1.Entities.Tracking;
using Postmaster.io.Managers;

namespace Postmaster.io.Api.V1
{
    /// <summary>
    /// Json object mapping.
    /// </summary>
    public class JObjectMapper
    {
        /// <summary>
        /// Map json Result array to Result model.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static List<Result> ResultArrayToModel(string json)
        {
            var resultList = new List<Result>();
            try
            {
                Tracking trackingResults = JsonConvert.DeserializeObject<Tracking>(json);
                resultList = trackingResults.Results;

            }
            catch (JsonSerializationException e)
            {
                ErrorHandlingManager.ReportError(e.Message, "JObjectMapper.cs", "ResultArrayToModel");
            }
            catch (Exception e)
            {
                ErrorHandlingManager.ReportError(e.Message, "JObjectMapper.cs", "ResultArrayToModel");
            }
            return resultList;
        }
    }
}
