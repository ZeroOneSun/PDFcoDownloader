using System;

namespace PDFco.Downloader.Contract
{
    public interface IDownloadBuilder
    {
        IDownload Build(Uri url, int bufferSize, long? offset, long? maxReadBytes);
    }
}