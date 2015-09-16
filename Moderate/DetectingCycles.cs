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
             //do something with line
            string cycle = FindCycle(line);
            Console.WriteLine(cycle);
        }

        //string line = "1 4 3 4 3 4 3 4 3";
    }
    static string FindCycle(string line)
    {
        string[] allSeperate = line.Split(' ');
        string firstString = "a";
        string secondString = "y";
        int i = 0;
        int k = 0;
        int n = 1;
        string pattern = null;
        bool patternFound = false;
        while (!patternFound)
        {
            firstString = allSeperate[i];

            if (k == 0)
            {
                k = i + 1;
            }
            if (k < allSeperate.Length)
            {
                if (i != k)
                {
                    secondString = allSeperate[k];

                    if (firstString == secondString)
                    {
                        pattern = firstString;
                        while (allSeperate[i + n] == allSeperate[k + n] && i + n < allSeperate.Length-1 && k + n < allSeperate.Length-1)
                        {
                            if (allSeperate[i] == allSeperate[i + n])
                            {
                                break;
                            }
                            pattern += " "+allSeperate[i + n];
                            n++;
                        }
                        if (k - n == i)
                        {
                            //Console.WriteLine("Pattern Found!");
                            //Console.WriteLine(pattern);
                            return (pattern);
                        }
                        else
                        {
                            pattern = null;
                            n = 0;
                        }
                    }
                }
                k++;
            }
            else
            {
                if (i < allSeperate.Length -1)
                {
                    i++;
                }else
                {
                    //Console.WriteLine("No pattern found");
                }
                k = 0;
            }
        }
        return "bzdura";
    }

}