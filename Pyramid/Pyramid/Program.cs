using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isBigger = false;
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                   
                    
                    if (counter==n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write($"{counter + " "}");
                    counter++;
                }

                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
