PDFcoDownloader
===============

A library for resuming and multi-part/multi-threaded downloads in .NET written in C#

 
Example for usage:
 
```C#
var url = new Uri("http://yourdomain.com/yourfile.zip"); 
var requestBuilder = new SimpleWebRequestBuilder();
var dlChecker = new DownloadChecker();
var httpDlBuilder = new SimpleDownloadBuilder(requestBuilder, dlChecker);
var timeForHeartbeat = 3000;
var timeToRetry = 5000;
var maxRetries = 5;
var rdlBuilder = new ResumingDownloadBuilder(timeForHeartbeat, timeToRetry, maxRetries, httpDlBuilder);
List<DownloadRange> alreadyDownloadedRanges = null;
var bufferSize = 4096;
var numberOfParts = 4;
var download = new MultiPartDownload(url, bufferSize, numberOfParts, rdlBuilder, requestBuilder, dlChecker, alreadyDownloadedRanges);
download.DownloadCompleted += (args) => Console.WriteLine("download has finished!");
var file = new FileInfo("yourfile.zip");
var dlSaver = new DownloadToFileSaver(file);
dlSaver.Attach(download);
download.Start();
```

For a more sophisticated example also demonstrating the download observers functionality, please have a look at the Downloader.Example project.

## Note on the number of concurrent/parallel downloads ##
.NET by default limits the number of concurrent connections. You can bypass this limit by manually setting the static `System.Net.ServicePointManager.DefaultConnectionLimit` property to a value appropriate to your application. Please also have a look at the documentation in the [MSDN](https://msdn.microsoft.com/en-us/library/system.net.servicepointmanager.defaultconnectionlimit.aspx)
