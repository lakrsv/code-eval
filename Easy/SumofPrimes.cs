using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPrimes = 0;
            int sumOfPrimes = 0;
            int i = 2;

            while (numOfPrimes < 1000)
            {
                if (isPrime(i))
                {
                    sumOfPrimes += i;
                    numOfPrimes++;
                }
                i++;
            }
            Console.WriteLine(sumOfPrimes);
            //Console.ReadLine();
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
}
