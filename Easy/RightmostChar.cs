using System;
using System.IO;
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
            if (line.Length > 0 && line != "")
            {
                string[] bothStrings = line.Split(',');
                char theChar = char.Parse(bothStrings[1]);
                char[] sentencetoChar = bothStrings[0].ToCharArray();

                for (int i = sentencetoChar.Length - 1; i >= 0; i--)
                {
                    if (sentencetoChar[i] == theChar)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("-1");
                    }
                }
                //Console.ReadLine();
            }
        }
    }
}