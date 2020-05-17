using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimeAndCompositeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            bool isPrime = true;
            int sumOfComposites = 0;
            int sumOfPrimes = 0;
            while ((command = Console.ReadLine()) != "stop")
            {
                int currentDigit = int.Parse(command);
                if (currentDigit < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                for (int i = 2; i <= Math.Sqrt(currentDigit); i++)
                {
                    if (currentDigit % i == 0)
                    {
                        isPrime = false;
                        sumOfComposites += currentDigit;
                    }

                }
                if (isPrime)
                {
                    sumOfPrimes += currentDigit;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is : {sumOfPrimes}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfComposites}");
        }
    }
}
