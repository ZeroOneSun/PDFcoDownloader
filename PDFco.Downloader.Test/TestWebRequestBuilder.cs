using System;
using PDFco.Downloader.Contract;

namespace PDFco.Downloader.Test
{
    public class TestWebRequestBuilder : IWebRequestBuilder
    {
        public System.Net.HttpWebRequest CreateRequest(Uri url, long? offset)
        {
            throw new NotImplementedException();
        }
    }
}
