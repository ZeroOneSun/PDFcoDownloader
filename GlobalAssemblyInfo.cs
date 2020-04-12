using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

[assembly: AssemblyProduct("PDFcoDownloader")]
[assembly: AssemblyCompany("created by PDFco")]
[assembly: AssemblyCopyright("MIT license")]

[assembly: AssemblyVersion("2.0.3.0")]
[assembly: AssemblyFileVersion("2.0.3.0")]

#if DEBUG
[assembly : AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif