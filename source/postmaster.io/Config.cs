namespace Postmaster.io
{
    /// <summary>
    /// Configuration settings.
    /// </summary>
    public class Config
    {
        public static string BaseUri
        {
            get { return "https://api.postmaster.io"; }
        }

        public static string Version
        {
            get { return "v1"; }
        }

        public static string FrameworkVersion
        {
            get { return "4.0";; }
        }

        public static string UserAgent
        {
            get { return "Postmaster/" + Version + " .NET " + FrameworkVersion; }
        }


        private static string _apiKey = "";
        public static string ApiKey
        {
            get { return _apiKey; }
            set { _apiKey = value; }
        }

        private static string _password = "";
        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}