using System;
using System.Net;

namespace PDFco.Downloader.Contract
{
    public interface IDownloadChecker
    {
        DownloadCheckResult CheckDownload(WebResponse response);

        DownloadCheckResult CheckDownload(Uri url, IWebRequestBuilder requestBuilder);
    }
}
