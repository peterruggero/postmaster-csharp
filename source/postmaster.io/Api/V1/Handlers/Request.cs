using System;
using System.IO;
using System.Net;
using System.Text;
using Postmaster.io.Api.V1.Entities;
using Postmaster.io.Managers;

namespace Postmaster.io.Api.V1.Handlers
{
    public static class Request
    {
        /// <summary>
        /// POST with specified url, headers and body.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="headers">Headers.</param>
        /// <param name="body">Body.</param>
        /// <param name="contentType">Content/Accept type.</param>
        public static ResponseEntity Post(string url, WebHeaderCollection headers, string body, string contentType = "application/json")
        {
            string response = null;
            try
            {
                using (WebClient wc = new WebClient())
                {
                    string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(Config.ApiKey + ":" + Config.Password));
                    wc.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;
                    wc.Encoding = Encoding.UTF8;

                    response = wc.UploadString(new Uri(url), body);
                }
            }
            catch (WebException e)
            {
                ErrorHandlingManager.ReportError(e.Message, "Request.cs", "Post");
            }
            catch (Exception e)
            {
                ErrorHandlingManager.ReportError(e.Message, "Request.cs", "Post");
            }
            return ResponseEntity.Convert(response);
        }

        public static ResponseEntity Post2(string url, string body, string contentType = "application/json")
        {
            WebRequest request = CreateWebRequest(url, "POST", contentType, body);

            ResponseEntity response = ResponseEntity.Convert(ReadResponse(request));

            return response;
        }

        /// <summary>
        /// GET with specified url, dataType and headers.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="acceptType">Accept type.</param>
        /// <param name="headers">Headers.</param>
        public static string Get1(string url, WebHeaderCollection headers, string acceptType = "application/json")
        {
            // create web request
            WebRequest request = CreateWebRequest(url, "GET", acceptType, null);

            // download/read data
            string response = ReadResponse(request);

            // return
            return response;
        }

        /// <summary>
        /// GET with specified url, dataType and headers.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="dataType">Data type.</param>
        /// <param name="headers">Headers.</param>
        public static string Get(string url, WebHeaderCollection headers, string dataType = "application/json")
        {
            string response = null;
            try
            {
                using (WebClient wc = new WebClient())
                {
                    string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(Config.ApiKey + ":" + Config.Password));
                    wc.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;

                    // no 401 from server?
                    // wc.Credentials = new NetworkCredential(Config.ApiKey, Config.Password);

                    wc.Encoding = Encoding.UTF8;
                    response = wc.DownloadString(new Uri(url));
                }
            }
            catch (WebException e)
            {
                ErrorHandlingManager.ReportError(e.Message, "Request.cs", "Get");
            }
            catch (Exception e)
            {
                ErrorHandlingManager.ReportError(e.Message, "Request.cs", "Get");
            }
            return response;
        }

        /// <summary>
        /// Creates the web request.
        /// </summary>
        /// <returns>The web request.</returns>
        /// <param name="url">URL.</param>
        /// <param name="method">HTTP Method.</param>
        /// <param name="body">Body.</param>
        private static WebRequest CreateWebRequest(string url, string method, string dataType, string body)
        {
            HttpWebRequest request = null;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = method;
                request.Accept = dataType;
                request.KeepAlive = false;
                string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(Config.ApiKey + ":" + Config.Password));
                request.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;

                if (request.Method == "GET")
                {
                    request.Credentials = new NetworkCredential(Config.ApiKey, Config.Password);
                }
                else
                {
                    request.ContentType = dataType;
                    request.AllowWriteStreamBuffering = true;

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(body);
                    }
                }
            }
            catch (WebException e)
            {
                ErrorHandlingManager.ReportError(e.Message, "Request.cs", "CreateWebRequest");
            }
            catch (Exception e)
            {
                ErrorHandlingManager.ReportError(e.Message, "Request.cs", "CreateWebRequest");
            }

            return request;
        }

        /// <summary>
        /// Reads the response.
        /// </summary>
        /// <returns>The response string.</returns>
        /// <param name="request">Input web request.</param>
        private static string ReadResponse(WebRequest request)
        {
            string content = null;
            if (request != null)
            {
                try
                {
                    using (var response = request.GetResponse())
                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        content = sr.ReadToEnd();
                    }
                }
                catch (WebException e)
                {
                    ErrorHandlingManager.ReportError(e.Message, "Request.cs", "ReadResponse");
                }
                catch (IOException e)
                {
                    ErrorHandlingManager.ReportError(e.Message, "Request.cs", "ReadResponse");
                }
                catch (Exception e)
                {
                    ErrorHandlingManager.ReportError(e.Message, "Request.cs", "ReadResponse");
                }
            }
            return content;
        }
    }
}

