namespace Postmaster.io
{
    /// <summary>
    /// Postermaster driver class.
    /// </summary>
    public sealed class Postmaster
    {
        /// <summary>
        /// Initialize configuration.
        /// </summary>
        /// <param name="apiKey">Postmaster API Key.</param>
        public static void Init(string apiKey)
        {
            Config.ApiKey = apiKey;
        }

        /// <summary>
        /// Initialize configuration.
        /// </summary>
        /// /// <param name="apiKey">PostmastAPI Key.</param>
        /// <param name="password">Postmaster password (may be optional).</param>
        public static void Init(string apiKey, string password)
        {
            Config.ApiKey = apiKey;
            Config.Password = password;
        }
    }
}
