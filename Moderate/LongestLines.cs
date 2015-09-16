using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool firstLine = true;
    static void Main(string[] args)
    {
        int n = -1;
        Dictionary<int, string> lines = new Dictionary<int, string>();
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            if (firstLine)
            {
                n = int.Parse(line);
                firstLine = false;
            }
            else
            {
                lines.Add(line.Length, line);
            }
            // do something with line
        }
        for (int i = 0; i < n; i++)
        {
            string biggestLine = lines[lines.Keys.Max()];
            Console.WriteLine(biggestLine);
            lines.Remove(lines.Keys.Max());
        }
    }
}