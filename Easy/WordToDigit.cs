using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    public enum Numbers
    {
        zero = 0,
        one = 1,
        two = 2,
        three = 3,
        four = 4,
        five = 5,
        six = 6,
        seven = 7,
        eight = 8,
        nine = 9
    }
    public static Numbers Number;
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            string digits = WordsToDigits(line);
            Console.WriteLine(digits);
            // do something with line
        }
    }
    static string WordsToDigits(string line)
    {
        string[] words = line.Split(';');
        string returnString = null;
        for (int i = 0; i < words.Length; i++)
        {
            Numbers thisNumber = (Numbers)Enum.Parse(typeof(Numbers), words[i]);
            returnString += (int)thisNumber;
        }
        return returnString;
    }
}