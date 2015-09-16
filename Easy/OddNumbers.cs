using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintOddNumbers();
            Console.ReadLine();
        }
        static void PrintOddNumbers()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
