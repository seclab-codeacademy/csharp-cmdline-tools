// %SystemRoot%\Microsoft.NET\Framework\v3.5\csc  /out:%TEMP%\md5hash.exe %TEMP%\md5hash.cs

using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;


class md5hash
{
    static void Main(string[] args)
    {

		byte[] hash;
		byte[] binaryData;

		FileStream inFile = new FileStream(args[0], FileMode.Open, FileAccess.Read);
  
		binaryData = new Byte[inFile.Length];
    	long bytesRead = inFile.Read(binaryData, 0,(int)inFile.Length);
		inFile.Close();

		hash = new MD5CryptoServiceProvider().ComputeHash(binaryData);
	
		StringBuilder output = new StringBuilder(hash.Length);
		for (int i = 0; i < hash.Length; i++)
		{
			output.Append(hash[i].ToString("X2"));
		}

		System.Console.WriteLine(output.ToString().ToLower()+" -- "+ args[0]);
	}
}