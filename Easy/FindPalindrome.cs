using System.Collections.Generic;
using System.IO;
using System;
namespace CodeEuler
{
    class Program
    {
        public static int currentLine = 0;
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    // do something with line
                    currentLine++;
                    FindPalindrome(int.Parse(line));
                }
        }
        static void FindPalindrome(int number)
        {
            int maxRepeats = 100;
            int currentRepeats = 0;
            while (currentRepeats < maxRepeats)
            {
                int reversednum = ReverseInt(number);
                if (number == reversednum)
                {
                    break;
                }
                number = number + reversednum;
                currentRepeats++;
            }
            if (currentRepeats < maxRepeats)
            {
                Console.WriteLine(currentRepeats + " " + number);
            }
        }
        static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }
}
