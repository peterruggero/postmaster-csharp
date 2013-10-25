namespace Postmaster.io
{
    /// <summary>
    /// Postermaster singletons.
    /// </summary>
    public sealed class Postmaster
    {
        public static void SetConfig(string apiKey, string password)
        {
            Config.ApiKey = apiKey;
            Config.Password = password;
        }
    }
}
