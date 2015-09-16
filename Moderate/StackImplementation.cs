using System.IO;
using System;
using System.Collections.Generic;

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
                 //do something with line
        //string line = "10 -2 4 5 3";
                StackNumbers(line);
            }
                //Console.ReadLine();
    }
    static void StackNumbers(string line)
    {
        string lineToOutput = null;
        int n = 0;
        Stack<int> intStack = new Stack<int>();
        string[] allStrings = line.Split(' ');
        int[] allInts = new int[allStrings.Length];

        for (int i = 0; i < allStrings.Length; i++)
        {
            int integer = int.Parse(allStrings[i]);
            allInts[i] = integer;
            intStack.Push(integer);
        }

        for (int i = 0; i < allInts.Length; i++)
        {
            if (i == n)
            {
                int intToWrite = intStack.Pop();
                n += 2;
                if (lineToOutput != null)
                {
                    lineToOutput += " "+intToWrite;
                }
                else
                {
                    lineToOutput += intToWrite;
                }
                if (intStack.Count > 0)
                {
                    intStack.Pop();
                }
            }
        }
        Console.WriteLine(lineToOutput);
        
    }
}