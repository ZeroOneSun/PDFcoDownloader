namespace PDFco.Downloader.Contract
{
    public interface IDownloadObserver
    {
        void Attach(IDownload download);

        void Detach(IDownload download);

        void DetachAll();
    }
}