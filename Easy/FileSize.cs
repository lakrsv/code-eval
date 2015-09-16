using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        byte[] allbytes = File.ReadAllBytes(args[0]);

        Console.WriteLine(allbytes.Length);
    }
}