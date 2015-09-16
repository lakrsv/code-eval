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
            char[] allChars = line.ToCharArray();
            int sum = 0;
            foreach (char character in allChars)
            {
                if (char.IsDigit(character))
                {
                    sum += int.Parse(character.ToString());
                }
            }
            Console.WriteLine(sum);
            sum = 0;
            // do something with line
        }
    }
}