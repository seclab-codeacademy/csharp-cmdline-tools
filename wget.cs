// 2011-01-20
//
//  usage:   wget.exe
// 
// %SystemRoot%\Microsoft.NET\Framework\v3.5\csc  /out:%TEMP%\wget.exe %TEMP%\wget.cs
// 

using System;
using System.Net;
using System.Text;

class WebDL {
	static void Main(string[] args) {
		WebClient wc = new WebClient();
		wc.DownloadFile(args[0], args[1]);
	}
}
