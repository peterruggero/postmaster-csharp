using System.Diagnostics;

namespace Postmaster.io.Managers
{
    /// <summary>
    /// Provides basic error reporting.
    /// </summary>
    public static class ErrorHandlingManager
    {
        /// <summary>
        /// Reports error
        /// </summary>
        /// <param name="error">Error.</param>
        /// <param name="fileName">File name.</param>
        /// <param name="methodName">Method name.</param>
        public static void ReportError(string error, string fileName, string methodName)
        {
            Debug.WriteLine(@"====================================ERROR=================================");

            Debug.WriteLine(@"FILE NAME: " + fileName);
            Debug.WriteLine(@"METHOD NAME: " + methodName);
            Debug.WriteLine(@"ERROR: " + error);

            Debug.WriteLine(@"====================================ERROR=================================");
        }
    }
}