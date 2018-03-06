using System;
using PDFco.Downloader.Contract;

namespace PDFco.Downloader.Test
{
    public class TestDownloadChecker : IDownloadChecker
    {
        public DownloadCheckResult CheckDownload(Uri url, IWebRequestBuilder requestBuilder)
        {
            return this.CheckDownload(null);
        }

        public DownloadCheckResult CheckDownload(System.Net.WebResponse response)
        {
            return new DownloadCheckResult() { Size = 4000, SupportsResume = true };
        }
    }
}
