using System;
using System.IO;
using System.Reflection;
using Postmaster.io.Managers;

namespace Postmaster.io
{
    /// <summary>
    /// Postermaster driver class.
    /// </summary>
    public class Postmaster
    {
        /// <summary>
        /// Initialize configuration.
        /// </summary>
        /// <param name="apiKey">Postmaster API key.</param>
        public static void Init(string apiKey)
        {
            Config.ApiKey = apiKey;

            EnableDynamicLoadingForDlls(Assembly.GetExecutingAssembly(), "Newtonsoft.Json.dll");
        }

        /// <summary>
        /// Initialize configuration.
        /// </summary>
        /// /// <param name="apiKey">Postmast API key.</param>
        /// <param name="password">Postmaster password (may be optional).</param>
        public static void Init(string apiKey, string password)
        {
            Config.ApiKey = apiKey;
            Config.Password = password;
        }

        private static void EnableDynamicLoadingForDlls(Assembly assemblyToLoadFrom, string embeddedResource)
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                try
                {
                    string resName = embeddedResource + "." + args.Name.Split(',')[0];
                    using (Stream input = assemblyToLoadFrom.GetManifestResourceStream(resName))
                    {
                        return input != null
                            ? Assembly.Load(StreamToBytes(input))
                            : null;
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandlingManager.ReportError("Error dynamically loading dll: " + args.Name + " " + ex,
                        "Postmaster.cs", "EnableDynamicLoadingForDlls");
                    return null;
                }
            };
        }

        /// <summary>
        /// Stream input data to bytes.
        /// </summary>
        /// <param name="input">Input data.</param>
        /// <returns>Byte array.</returns>
        private static byte[] StreamToBytes(Stream input)
        {
            int capacity = input.CanSeek ? (int)input.Length : 0;
            using (MemoryStream output = new MemoryStream(capacity))
            {
                int readLength;
                byte[] buffer = new byte[4096];

                do
                {
                    readLength = input.Read(buffer, 0, buffer.Length);
                    output.Write(buffer, 0, readLength);
                }
                while (readLength != 0);

                return output.ToArray();
            }
        }
    }
}
