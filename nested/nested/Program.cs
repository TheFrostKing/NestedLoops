using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int p = 1; p <= 9; p++)
                        {
                            if (n % i == 0 && n % k == 0 && n % j == 0 && n % p == 0)
                            {
                                Console.Write($"{i}{k}{j}{p} ");
                            }
                        }
                    }
                }
            }


        }
    }
}
