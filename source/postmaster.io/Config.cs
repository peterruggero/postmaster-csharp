using System;

namespace Postmaster.io
{
    /// <summary>
    /// Configuration settings.
    /// </summary>
    public class Config
    {
        public const string BaseUri = "https://api.postmaster.io";
        public const string Version = "v1";
        public const string FrameworkVersion = "4.0";
        public const string UserAgent = "Postmaster/" + Version + " .NET" + FrameworkVersion;
        public const string ApiKey = "";
        public const string Password = "";
    }
}