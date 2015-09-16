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
                string[] bothStrings = line.Split(',');
                int start = int.Parse(bothStrings[0]);
                int end = int.Parse(bothStrings[1]);
                int primeCount = 0;
                for (int i = start; i <= end; i++)
                {
                    if (isPrime(i))
                    {
                        primeCount++;
                    }
                }
                Console.WriteLine(primeCount);
            }
    }
    static bool isPrime(int number)
    {
        if (number <= 1) { return false; }
        else if (number <= 3) { return true; }
        else if (number % 2 == 0 || number % 3 == 0) { return false; }

        int i = 5;

        while (i * i <= number)
        {
            if (number % i == 0 || number % (i + 2) == 0) { return false; }
            i = i + 6;
        }
        return true;
    }
}
