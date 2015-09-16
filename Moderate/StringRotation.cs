using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        //using (StreamReader reader = File.OpenText(args[0]))
        //    while (!reader.EndOfStream)
        //    {
        //        string line = reader.ReadLine();
        //        if (null == line)
        //            continue;

        //        // do something with line
        //        Console.WriteLine(CheckIfReversed(line).ToString());
        //    }
        string line = "Hellho,ellhoH";
        Console.Write(CheckIfReversed(line));
        Console.ReadLine();

    }
    static bool CheckIfReversed(string line)
    {
        string[] theWords = line.Split(',');

        if (theWords[0].Length != theWords[1].Length)
        {
            return false;
        }
        char[] firstWordChars = theWords[0].ToCharArray();
        char[] secondWordChars = theWords[1].ToCharArray();

        bool containsFirstChar = false;
        int indexOfStart = -1;
        for (int i = 0; i < theWords[1].Length; i++)
        {
            if (secondWordChars[i] == firstWordChars[0])
            {
                if (indexOfStart == -1)
                {
                    indexOfStart = i;
                    containsFirstChar = true;
                    break;
                }
            }
        }
        if (!containsFirstChar)
        {
            return false;
        }

        string dupedWord = "";
        int limit = 0;
        int k = indexOfStart;
        while (dupedWord.Length != firstWordChars.Length &&  limit < firstWordChars.Length)
        {
            dupedWord += secondWordChars[k];
            if (k < firstWordChars.Length -1)
            {
                k++;
            }
            else
            {
                k = 0;
            }
            limit++;
        }

        if (dupedWord == theWords[0])
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}