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

            string output = FindLongestWord(line);
            Console.WriteLine(output);
            // do something with line
        }
    }
    static string FindLongestWord(string line)
    {
        string[] words = line.Split(' ');
        int biggestSize = 0;
        string currentWord = null;
        foreach (string word in words)
        {
            if (word.Length > biggestSize)
            {
                biggestSize = word.Length;
                currentWord = word;
            }
        }

        return currentWord;
    }
}