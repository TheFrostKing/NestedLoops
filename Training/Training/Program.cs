using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int i =floors; i>=1; i--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    
                    if (i%2==0&&floors!=i)
                    {
                        Console.Write($"O{i}{r} "); 
                    }
         
                   if(i == floors)
                    {
                        Console.Write($"L{i}{r} ");
                    }
                    else if(i%2!=0)
                    {
                        Console.Write($"A{i}{r} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
