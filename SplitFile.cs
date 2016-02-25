// 2011-01-20
//
// usage:   split [infile] [offset]  [out-part1]  [out-part2]
// 
// %SystemRoot%\Microsoft.NET\Framework\v3.5\csc  /out:%TEMP%\split.exe %TEMP%\SplitFile.cs
// 
// check file size of dark.gif: 2,281 bytes  >> will be used as offset
// copy /b dark.gif+HxD.exe dark_Hxd.gif
// split dark_Hxd.gif 2281 dark_original.gif exploit.exe 


using System;
using System.IO;

class SplitFile
{
    static void Main(string[] args)
    {
		int splitOffset = (int)Convert.ToInt64(args[1]); 

		FileStream inFile = new FileStream(args[0], FileMode.Open, FileAccess.Read);
  
		byte[] binaryData = new Byte[inFile.Length];
		long bytesRead = inFile.Read(binaryData, 0,(int)inFile.Length);
		inFile.Close();
  
		Console.WriteLine(binaryData.Length);
		Console.WriteLine(splitOffset);
		Console.WriteLine(binaryData.Length-splitOffset);

		FileStream outFilePart1 = new FileStream(args[2], FileMode.Create);
		outFilePart1.Write(binaryData, 0, splitOffset); 
		outFilePart1.Close();     

		FileStream outFilePart2 = new FileStream(args[3], FileMode.Create);
		outFilePart2.Write(binaryData, splitOffset, binaryData.Length-splitOffset); 
		outFilePart2.Close();     
   }
} 