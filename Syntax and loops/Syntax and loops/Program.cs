using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= row; i++)
            {
                counter++;
                for (int r = 1; r <= i; r++)
                {
                    
                    Console.Write(counter);
                }    
                
                Console.WriteLine();
            }
        }
    }
}
