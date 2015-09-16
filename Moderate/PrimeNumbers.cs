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
                string primes = FindPrimesLessThan(line);
                Console.WriteLine(primes);
            }
    }
    static string FindPrimesLessThan(string line)
    {
        int n = int.Parse(line);
        string returnString = null;
        for (int i = 0; i < n; i++)
        {
            if (isPrime(i))
            {
                if (returnString == null)
                {
                    returnString += i;
                }
                else
                {
                    returnString += "," + i;
                }
            }
        }
        return returnString;
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