using System;

namespace PDFco.Downloader.Contract.Exceptions
{
    public class TooManyRetriesException : Exception
    {
        public TooManyRetriesException()
            : base()
        {
        }
    }
}
