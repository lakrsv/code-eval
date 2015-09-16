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
                char unrepeatedChar = ReturnFirstUnrepeatedChar(line);
                Console.WriteLine(unrepeatedChar);
            }
        

    }
    static char ReturnFirstUnrepeatedChar(string line)
    {
        char[] allCharacters = line.ToCharArray();
        for (int i = 0; i < allCharacters.Length; i++)
        {
            int charCount = 0;
            for (int k = 0; k < allCharacters.Length; k++)
            {
                if (allCharacters[i] == allCharacters[k])
                {
                    charCount++;
                }
            }
            if (charCount == 1)
            {
                return allCharacters[i];
            }
        }
            return 'e';
    }
}