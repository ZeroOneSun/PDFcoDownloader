using System;
using System.Net;

namespace PDFco.Downloader.Contract
{
    public interface IWebRequestBuilder
    {
        HttpWebRequest CreateRequest(Uri url, long? offset);
    }
}
