using System;
using System.Net;
using System.Reflection;
using PDFco.Downloader.Contract;

namespace PDFco.Downloader.Utils
{
    public class SimpleWebRequestBuilder : IWebRequestBuilder
    {
        public SimpleWebRequestBuilder(int timeout)
        {
            this.Timeout = timeout;
        }

        public SimpleWebRequestBuilder(IWebProxy proxy)
        {
            this.Proxy = proxy;
        }

        public SimpleWebRequestBuilder()
            : this(null)
        {
        }

        public int Timeout { get; set; } = 100;

        public IWebProxy Proxy { get; private set; }

        public HttpWebRequest CreateRequest(Uri url, long? offset)
        { 
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Timeout = Timeout;

            if (Proxy != null)
            {
                request.Proxy = Proxy;
            }

            if (offset.HasValue && offset.Value > 0)
            {
                // Only works with long values starting with .NET 4:
                // request.AddRange(offset.Value);

                this.AddLongRangeInDotNet3_5(request, offset.Value);
            }

            return request;
        }

        private void AddLongRangeInDotNet3_5(HttpWebRequest request, long offset)
        {
            var method = typeof(WebHeaderCollection).GetMethod("AddWithoutValidate", BindingFlags.Instance | BindingFlags.NonPublic);

            string key = "Range";
            string val = string.Format("bytes={0}-", offset);

            method.Invoke(request.Headers, new object[] { key, val });
        }
    }
}
