using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Postmaster.io
{
    /// <summary>
    /// Postermaster driver class.
    /// </summary>
    public static class Postmaster
    {
        /// <summary>
        /// Initialize configuration.
        /// </summary>
        /// <param name="apiKey">Postmaster API key.</param>
        public static void Init(string apiKey)
        {
            // load json.net resource
            string resource = "Postmaster.io.Libraries.Newtonsoft.Json.dll";
            EmbeddedAssembly.Load(resource, "Newtonsoft.Json.dll");

            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;


            // set Postmaster API key
            Config.ApiKey = apiKey;
        }

        /// <summary>
        /// Initialize configuration.
        /// </summary>
        /// /// <param name="apiKey">Postmast API key.</param>
        /// <param name="password">Postmaster password (may be optional).</param>
        public static void Init(string apiKey, string password)
        {
            // load json.net resource
            string resource = "Postmaster.io.Libraries.Newtonsoft.Json.dll";
            EmbeddedAssembly.Load(resource, "Newtonsoft.Json.dll");

            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            Config.ApiKey = apiKey;
            Config.Password = password;
        }

        /// <summary>
        /// ResolveEvent handler for loading third-party libraries;
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="args">Args.</param>
        /// <returns>Embedded Assembly.</returns>
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }

        /// <summary>
        /// Subscribe to AssemblyResolve event in the case that a third-party
        /// library fails to load initially.
        /// </summary>
        /// <param name="assemblyToLoadFrom">Current running Assembly.</param>
        /// <param name="embeddedResourcePrefix">Resource prefix (name).</param>
        public static void EnableDynamicLoadingForDlls(Assembly assemblyToLoadFrom, string embeddedResourcePrefix)
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                try
                {
                    string resName = embeddedResourcePrefix + "." + args.Name.Split(',')[0] + ".dll";
                    using (Stream input = assemblyToLoadFrom.GetManifestResourceStream(resName))
                    {
                        return input != null
                             ? Assembly.Load(StreamToBytes(input))
                             : null;
                    }
                }
                catch (Exception ex)
                {
                    
                    Debug.WriteLine("Error dynamically loading dll: " + args.Name, ex);
                    return null;
                }
            };
        }

        /// <summary>
        /// Stream input stream to bytes.
        /// </summary>
        /// <param name="input">Input stream.</param>
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
                    readLength = input.Read(buffer, 0, buffer.Length); // had to change to buffer.Length
                    output.Write(buffer, 0, readLength);
                }
                while (readLength != 0);

                return output.ToArray();
            }
        }
    }
}
