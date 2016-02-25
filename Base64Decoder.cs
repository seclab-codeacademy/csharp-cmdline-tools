// 2011-01-20
//
//  usage:   base64decoder [textfile.b64.txt] [binaryfile.exe]
// 
// %SystemRoot%\Microsoft.NET\Framework\v3.5\csc  /out:%TEMP%\d64.exe %TEMP%\Base64Decoder.cs
//
// d64.exe  HxD.exe.b64.txt  HxD000.exe


using System;
using System.IO;

class Base64Decoder
{
    static void Main(string[] args)
    {

       StreamReader reader = new StreamReader(args[0]);
       string line = reader.ReadLine();
       reader.Close();
  
       byte[] toDecodeByte = Convert.FromBase64String(line);
  
       FileStream outfileStream = new FileStream(args[1], FileMode.Create);
       outfileStream.Write(toDecodeByte, 0, toDecodeByte.Length); 
       outfileStream.Close(); 
    }
} 
