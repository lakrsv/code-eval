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
                string fizzed = GetFizzBuzz(line);
                Console.WriteLine(fizzed);
            }
    }
    static int[] SeperateNumbers(string line)
    {
        string[] threenums = line.Split(' ');

        int x = int.Parse(threenums[0]);
        int y = int.Parse(threenums[1]);
        int n = int.Parse(threenums[2]);

        int[] returnInt = new int[3];
        returnInt[0] = x;
        returnInt[1] = y;
        returnInt[2] = n;

        return returnInt;
    }
    static string GetFizzBuzz(string line)
    {
        string toPrint = null;
        int[] numbers = SeperateNumbers(line);
        int x = numbers[0];
        int y = numbers[1];
        int n = numbers[2];

        for (int i = 1; i <= n; i++)
        {
            if (i % x == 0 && i % y == 0)
            {
                toPrint += " FB";
            }
            else if (i % x == 0)
            {
                toPrint += " F";
            }
            else if (i % y == 0)
            {
                toPrint += " B";
            }
            else
            {
                toPrint += " "+i;
            }
        }
        string fizzBuzzedLine = RemoveFirstChar(toPrint);

        return fizzBuzzedLine;
    }
    static string RemoveFirstChar(string line)
    {
        char[] linetoChar = line.ToCharArray();
        char[] tempNewLine = new char[linetoChar.Length - 1];
        for (int i = 1; i < linetoChar.Length; i++)
        {
            tempNewLine[i - 1] = linetoChar[i];
        }
        string toReturn = new string(tempNewLine);

        return toReturn;
    }
}