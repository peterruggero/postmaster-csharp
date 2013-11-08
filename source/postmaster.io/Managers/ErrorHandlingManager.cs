using System.Diagnostics;

namespace Postmaster.io.Managers
{
    /// <summary>
    /// Provide basic error reporting.
    /// </summary>
    public static class ErrorHandlingManager
    {
        /// <summary>
        /// Report error.
        /// </summary>
        /// <param name="error">Error.</param>
        /// <param name="details">Details.</param>
        /// <param name="fileName">File name.</param>
        /// <param name="methodName">Method name.</param>
        public static void ReportError(string error, string details, string fileName, string methodName)
        {
            Debug.WriteLine(@"====================================ERROR=================================");

            Debug.WriteLine(@"FILE NAME: " + fileName);
            Debug.WriteLine(@"METHOD NAME: " + methodName);
            Debug.WriteLine(@"ERROR: " + error);
            Debug.WriteLine(@"DETAILS: " + details);

            Debug.WriteLine(@"====================================ERROR=================================");
        }

        /// <summary>
        /// Report error.
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

        /// <summary>
        /// Print error message.
        /// </summary>
        /// <param name="message">Message.</param>
        public static void PrintMessage(string message)
        {
            Debug.WriteLine(@"====================================ERROR=================================");
            Debug.WriteLine(@"MESSAGE: " + message);
            Debug.WriteLine(@"====================================ERROR=================================");
        }
    }
}