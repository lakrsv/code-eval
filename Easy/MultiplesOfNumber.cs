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
                // do something with line
                string[] theStrings = line.Split(',');

                int x = int.Parse(theStrings[0]);
                int n = int.Parse(theStrings[1]);
                int sum = 0;

                if (n == x) { Console.WriteLine(n); }

                while (sum < x)
                {
                    sum += n;
                }
                Console.WriteLine(sum);
            }
    }
}