using System.IO;
using System.Collections.Generic;
using System;

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
                // do something with line
                string output = ReturnSentence(line);
                Console.WriteLine(output);
            }
        //string line = "osSE5Gu0Vi8WRq93UvkYZCjaOKeNJfTyH6tzDQbxFm4M1ndXIPh27wBA rLclpg| 3 35 27 62 51 27 46 57 26 10 46 63 57 45 15 43 53";
        //Console.ReadLine();
    }
    static string ReturnSentence(string line)
    {
        string[] theSentences = line.Split('|');
        char[] sentenceChars = theSentences[0].ToCharArray();
        string[] allIndexes = (theSentences[1].Split(' '));
        string lineToReturn = null;
        foreach (string index in allIndexes)
        {
            if (index.Length > 0)
            {
                int indexToInt = int.Parse(index);
                lineToReturn += sentenceChars[indexToInt - 1];
            }
        }
        return lineToReturn;
    }
}