using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string printString = null;
            string KEY = "BHISOECRTMGWYVALUZDNFJKPQX";
            string MSG = "012222 1114142503 0313012513 03141418192102 0113 2419182119021713 06131715070119";

            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < KEY.Length; i++)
            {
                dictionary[KEY[i]] = i;
            }

            int n = 0;
            while (n < MSG.Length)
            {
                if (MSG[n] == ' ')
                {
                    printString+=' ';
                    n++;
                    continue;
                }
                int val = 0;
                val = MSG[n++] - '0';
                val *= 10;
                val += MSG[n++]-'0';

                printString +=((char)('A' + dictionary[(char)('A' + val)]));
            }
            Console.WriteLine(printString);
            //Console.ReadLine();

        }
    }
}
