using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText("sample.txt"))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
            char[] allCharacters = line.ToCharArray();

            string newLine = null;
            char currentChar = '@';
            foreach (char character in allCharacters)
            {
                if (currentChar != character)
                {
                    currentChar = character;
                    newLine += character;
                }
            }
            Console.WriteLine(newLine);
            Console.ReadLine();
        }
    }
}