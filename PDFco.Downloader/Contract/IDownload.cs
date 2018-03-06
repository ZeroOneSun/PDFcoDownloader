using System;
using PDFco.Downloader.Contract.Enums;
using PDFco.Downloader.Contract.Events;

namespace PDFco.Downloader.Contract
{
    public interface IDownload : IDisposable
    {
        event DownloadDelegates.DownloadDataReceivedHandler DataReceived;

        event DownloadDelegates.DownloadStartedHandler DownloadStarted;

        event DownloadDelegates.DownloadCompletedHandler DownloadCompleted;

        event DownloadDelegates.DownloadStoppedHandler DownloadStopped;

        event DownloadDelegates.DownloadCancelledHandler DownloadCancelled;

        DownloadState State { get; }

        void Start();

        void Stop();

        void DetachAllHandlers();
    }
}