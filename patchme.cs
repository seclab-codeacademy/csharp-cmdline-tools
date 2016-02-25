// 2011-01-20
// usage:   patchme  [binaryfile.exe] [offset] [new-hexvalue]
// 
// %SystemRoot%\Microsoft.NET\Framework\v3.5\csc  /out:%TEMP%\patchme.exe %TEMP%\patchme.cs
//
// Search for: 440069  (Hex-Values)
//
// patchme.exe  cmd_disabled.exe 21100  21  


using System;
using System.IO;

class Base64Encoder
{
    static void Main(string[] args)
    {
		int offSet = (int)Convert.ToInt64(args[1]); 
		byte newHexValue = Convert.ToByte(args[2], 16);
  
		FileStream inFile = new FileStream(args[0], FileMode.Open, FileAccess.Read);
  
		byte[] binaryData = new Byte[inFile.Length];
		long bytesRead = inFile.Read(binaryData, 0,(int)inFile.Length);
		inFile.Close();
  
		binaryData[offSet] = newHexValue;
		
		FileStream outFile = new FileStream(args[0], FileMode.Create);
		outFile.Write(binaryData, 0, binaryData.Length); 
		outFile.Close();     
     }
} 
