using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;

            string[] theStrings = line.Split(',');
            bool isEqual = CompareBitPositions(theStrings[0], theStrings[1], theStrings[2]);
            Console.WriteLine(isEqual.ToString().ToLower());
            Console.ReadLine();
            // do something with line


        }
    }
    static bool CompareBitPositions(string number, string x, string y)
    {
        int theNumber = int.Parse(number);
        int xPos = int.Parse(x)-1;
        int yPos = int.Parse(y)-1;

        BitArray b = new BitArray(new int[] { theNumber });
        bool[] bits = new bool[b.Count];
        b.CopyTo(bits, 0);

        if (bits[xPos] == bits[yPos])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}